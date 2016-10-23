﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using Common;
using Ninject;
using Ninject.Web;
using Service.Models;
using Service.Repositories;

namespace Service
{
    public class Authentication : SoapHeader
    {
        public string User;
        public string Password;
    }
    /// <summary>
    /// Summary description for StockExchangeService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class StockExchangeService : WebServiceBase
    {
        public Authentication Authentication { get; set; }

        [Inject]
        public IStockRepository StockRepository { get; set; }


        [WebMethod]
        [SoapHeader("Authentication")]
        public GetAllResponseMessage GetAll(int page = 1, int size = 15)
        {
            if (!CheckAuthenticationHeader())
            {
                return null;
            }
            var stocks = StockRepository.GetAll().OrderBy(s => s.Id).Pager(page, size);
            var count = StockRepository.GetAll().Count();

            return new GetAllResponseMessage()
            {
                Count = count,
                Page = page,
                Size = size,
                Stocks = stocks.Select(s => new StockDetails() {Id = s.Id, Price = s.Price}).ToList()
            };
        }

        [WebMethod]
        [SoapHeader("Authentication")]
        public GetByIdsResponseMessage GetByIds(List<int> ids, int page = 1, int size = 15)
        {
            if (!CheckAuthenticationHeader())
            {
                return null;
            }

            var stocks = StockRepository.GetByIds(ids).OrderBy(s => s.Id).Pager(page, size);
            var count = StockRepository.GetByIds(ids).Count();

            return new GetByIdsResponseMessage()
            {
                Count = count,
                Page = page,
                Size = size,
                Stocks = stocks.Select(s => new StockDetails() { Id = s.Id, Price = s.Price }).ToList()
            };
        }


        [WebMethod]
        [SoapHeader("Authentication")]
        public GetByIdResponseMessage GetById(int id)
        {
            if (!CheckAuthenticationHeader())
            {
                return null;
            }

            var stock = StockRepository.GetById(id);
            return new GetByIdResponseMessage()
            {
                Stock = new StockDetails() { Id = stock.Id, Price = stock.Price}
            };
        }


        bool CheckAuthenticationHeader()
        {
            if (Authentication?.User == "testuser" && Authentication?.Password == "testpassword")
            {
                return true;
            }

            Context.Response.Status = "403 Forbidden";
            //the next line is untested - thanks to strider for this line
            Context.Response.StatusCode = 403;
            //the next line can result in a ThreadAbortException
            //Context.Response.End(); 
            Context.ApplicationInstance.CompleteRequest();
            return false;
        }
    }
}
