﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebShopApp.Core.Contracts;
using WebShopApp.Models.Statistic;

namespace WebShopApp.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly IStatisticsService statisticsService;

        public StatisticsController(IStatisticsService statisticsService)
        {
            this.statisticsService = statisticsService;
        }

        // GET: StatisticsController
        public ActionResult Index()
        {
            StatisticVM statistics = new StatisticVM();

            statistics.CountClients = statisticsService.CountClients();
            statistics.CountProducts = statisticsService.CountProducts();
            statistics.CountOrders = statisticsService.CountOrders();

            return View(statistics);
        }

        // GET: StatisticsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StatisticsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StatisticsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StatisticsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StatisticsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StatisticsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StatisticsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
