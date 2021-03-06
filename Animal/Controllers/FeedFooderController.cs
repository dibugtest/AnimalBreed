﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Animal.Models;
using Animal.Models.ViewModel;
using Animal.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Animal.Controllers
{
     //[Authorize(Roles ="SuperAdmin")]
    public class FeedFooderController : Controller
    {
        // private readonly IRepository<FeedFooder> _repo;
        private readonly IUnitOfWork _repoU;

        public FeedFooderController(IUnitOfWork repoU)
        {
            //   _repo = repo;
            _repoU = repoU;
        }


        public IActionResult Index()
        {
            IEnumerable<FeedFooder> all = _repoU.FeedFooder.GetModel();
            //IEnumerable<FeedFooder> all = _repo.GetModel();
            return View(all);
        }

        public IActionResult Details(int id)
        {
            FeedFooder feed = _repoU.FeedFooder.GetById(id);
            return View(feed);
        }

        [HttpGet]
        public IActionResult AddEditFeed(int? id)
        {
            FeedFooder model = new FeedFooder();

            if (id.HasValue)
            {
                FeedFooder feed = _repoU.FeedFooder.GetById(id.Value);
                if (feed != null)
                {
                    model = feed;
                }
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult AddEditFeed(int? id, FeedFooder model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool isNew = !id.HasValue;
                    //FeedFooder feed = isNew ? new FeedFooder { } : _repo.GetById(id.Value);
                    // feed = model;
                    if (isNew)
                    {
                        _repoU.FeedFooder.Insert(model);
                        _repoU.FeedFooder.Save();
                    }
                    else
                    {
                        //To Avoid tracking error
                        // DbContextInMemory.Entry(entity).State = EntityState.Detached;
                        _repoU.FeedFooder.Update(model);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteFeed(int id)
        {
            FeedFooder feed = _repoU.FeedFooder.GetById(id);
            _repoU.FeedFooder.Delete(id);

            return RedirectToAction("Index");

        }



        [HttpGet]
        public IActionResult Calculation()
        {
            List<FeedCalculator> fooders = new List<FeedCalculator>();

            for (int i = 0; i < 3; i++)
            {
                FeedCalculator fooder1 = new FeedCalculator();
                if (i == 0)
                {
                    fooder1.feeds = new SelectList(_repoU.FeedFooder.GetByCategory("Green"), "id", "fooderNameEng");
                }
                else if (i == 1)
                {
                    fooder1.feeds = new SelectList(_repoU.FeedFooder.GetByCategory("Dry"), "id", "fooderNameEng");
                }
                else if (i == 2)
                {
                    fooder1.feeds = new SelectList(_repoU.FeedFooder.GetByCategory("Mineral"), "id", "fooderNameEng");
                }
                fooder1.animalCategories = new SelectList(_repoU.Species.GetModel(), "id", "speciesName");
                fooder1.fatPercentage = 0;
                fooder1.category = "";
                fooder1.weight = 0;
                fooder1.animalWeight = 0;
                fooder1.milkvolumn = "0";

                fooders.Add(fooder1);
            }
          

            return View(fooders);
        }
        [HttpPost]
        public IActionResult Calculation(List<FeedCalculator> feeds)
        {
            List<FeedCalculator> feedResult = new List<FeedCalculator>();
            string fat = feeds[0].fatPercentage.ToString();
            string type = feeds[0].milk;
            string preg = feeds[0].pregnancy;
            string volumn = feeds[0].milkvolumn;
            string species = feeds[0].species;
            string speciesName = _repoU.Species.GetById(int.Parse(species)).speciesName;

            GeneralNutration generalNutrition = new GeneralNutration();
            MIlkBaseNutrition MilkBase = new MIlkBaseNutrition();
            PregnancyBaseNutrition PregancyBase = new PregnancyBaseNutrition();

            if (_repoU.FeedFooder.GetById(feeds[0].feedId) == null ||
                _repoU.GeneralNutrition.GetByWeight(feeds[0].animalWeight.ToString(), species) == null
                )
            {

                ModelState.AddModelError(string.Empty, "Feed Fooder Record Not Found.");
                feeds[0].feeds = new SelectList(_repoU.FeedFooder.GetModel(), "id", "fooderNameEng", feeds[0].feedId);
                feeds[0].animalCategories = new SelectList(_repoU.Species.GetModel(), "speciesName", "speciesName", feeds[0].category);
                return View(feeds);
            }
          
            for (int i = 0; i < feeds.Count; i++)
            {
                if (feedResult.Count == 0 && (feeds[i].feedId.ToString() != "" && feeds[i].feedId != 0))
                {
                    FeedFooder fooder = _repoU.FeedFooder.GetById(feeds[i].feedId);
                    FeedCalculator feed1 = new FeedCalculator();
                    feed1.dm = (Convert.ToDecimal(feeds[i].weight) * Convert.ToDecimal(fooder.dm) * Convert.ToDecimal(0.01)).ToString("0.00");
                    feed1.c = (Convert.ToDecimal(feeds[i].weight) * Convert.ToDecimal(fooder.c) * Convert.ToDecimal(0.01)).ToString("0.00");
                    feed1.p = (Convert.ToDecimal(feeds[i].weight) * Convert.ToDecimal(fooder.p) * Convert.ToDecimal(0.01)).ToString("0.00");
                    feed1.tdn = (Convert.ToDecimal(feeds[i].weight) * Convert.ToDecimal(fooder.tdn) * Convert.ToDecimal(0.01)).ToString("0.00");
                    feed1.dcp = (Convert.ToDecimal(feeds[i].weight) * Convert.ToDecimal(fooder.dm) * Convert.ToDecimal(0.01)).ToString("0.00");
                    feed1.me = (Convert.ToDecimal(feeds[i].weight) * Convert.ToDecimal(fooder.dm) * Convert.ToDecimal(0.01)).ToString("0.00");
                    feed1.fatPercentage = feeds[0].fatPercentage;
                    feed1.animalWeight = feeds[0].animalWeight;
                    feed1.animalCategories = feeds[0].animalCategories;
                    feed1.remarks = "Feed Fooder";

                    feedResult.Add(feed1);
                }
                else if (feedResult.Count == 1 && feeds[i].feedId.ToString() != "" && feeds[i].feedId != 0)
                {
                    FeedFooder fooder = _repoU.FeedFooder.GetById(feeds[i].feedId);
                    feedResult[0].dm = (Convert.ToDecimal(feedResult[0].dm) + Convert.ToDecimal(feeds[i].weight) * Convert.ToDecimal(fooder.dm) * Convert.ToDecimal(0.01)).ToString("0.00");
                    feedResult[0].c = (Convert.ToDecimal(feedResult[0].c) + Convert.ToDecimal(feeds[i].weight) * Convert.ToDecimal(fooder.c) * Convert.ToDecimal(0.01)).ToString("0.00");
                    feedResult[0].p = (Convert.ToDecimal(feedResult[0].p) + Convert.ToDecimal(feeds[i].weight) * Convert.ToDecimal(fooder.p) * Convert.ToDecimal(0.01)).ToString("0.00");
                    feedResult[0].tdn = (Convert.ToDecimal(feedResult[0].tdn) + Convert.ToDecimal(feeds[i].weight) * Convert.ToDecimal(fooder.tdn) * Convert.ToDecimal(0.01)).ToString("0.00");
                    feedResult[0].dcp = (Convert.ToDecimal(feedResult[0].dcp) + Convert.ToDecimal(feeds[i].weight) * Convert.ToDecimal(fooder.dm) * Convert.ToDecimal(0.01)).ToString("0.00");
                    feedResult[0].me = (Convert.ToDecimal(feedResult[0].me) + Convert.ToDecimal(feeds[i].weight) * Convert.ToDecimal(fooder.dm) * Convert.ToDecimal(0.01)).ToString("0.00");

                }
            }



            if (type == "Yes")
            {
                generalNutrition = _repoU.GeneralNutrition.GetByWeight(feeds[0].animalWeight.ToString(), species);

                MilkBase = _repoU.MilkBase.GetByFat(fat, int.Parse(species));
                if (MilkBase == null)
                {
                    ModelState.AddModelError(string.Empty, "Milk Base Record Not Found.");
                    feeds[0].feeds = new SelectList(_repoU.FeedFooder.GetModel(), "id", "fooderNameEng", feeds[0].feedId);
                    feeds[0].animalCategories = new SelectList(_repoU.Species.GetModel(), "speciesName", "speciesName", feeds[0].category);
                    return View(feeds);
                }
                FeedCalculator feed = new FeedCalculator();
                feed.dm = (Convert.ToDecimal(generalNutrition.dm) + Convert.ToDecimal(MilkBase.dm)).ToString();
                feed.tdn = (Convert.ToDecimal(generalNutrition.tdn) + Convert.ToDecimal(MilkBase.tdn)).ToString();
                feed.p = (Convert.ToDecimal(generalNutrition.p) + Convert.ToDecimal(MilkBase.p)).ToString();
                feed.c = (Convert.ToDecimal(generalNutrition.c) + Convert.ToDecimal(MilkBase.c)).ToString();
                // feed.me = generalNutrition.me;
                //feed.dcp = generalNutrition.dp;
                feed.fatPercentage = feeds[0].fatPercentage;
                feed.category = feeds[0].category;
                feed.animalWeight = feeds[0].animalWeight;
                feed.remarks = "Required";
                feedResult.Add(feed);


            }
            if (!string.IsNullOrEmpty(preg))
            {
                if (preg != "No")
                {
                    generalNutrition = _repoU.GeneralNutrition.GetByWeight(feeds[0].animalWeight.ToString(), species);

                    PregancyBase = _repoU.PregnancyBaseNutrition.GetBySpecies(feeds[0].animalWeight.ToString());
                    if (PregancyBase == null)
                    {
                        ModelState.AddModelError(string.Empty, "Preganancy Base Record Not Found.");
                        feeds[0].feeds = new SelectList(_repoU.FeedFooder.GetModel(), "id", "fooderNameEng", feeds[0].feedId);
                        feeds[0].animalCategories = new SelectList(_repoU.Species.GetModel(), "speciesName", "speciesName", feeds[0].category);
                        return View(feeds);
                    }

                    FeedCalculator feed = new FeedCalculator();
                    feed.dm = (Convert.ToDecimal(generalNutrition.dm) + Convert.ToDecimal(PregancyBase.dm)).ToString();
                    feed.tdn = (Convert.ToDecimal(generalNutrition.tdn) + Convert.ToDecimal(PregancyBase.tdn)).ToString();
                    feed.p = (Convert.ToDecimal(generalNutrition.p) + Convert.ToDecimal(PregancyBase.p)).ToString();
                    feed.c = (Convert.ToDecimal(generalNutrition.c) + Convert.ToDecimal(PregancyBase.c)).ToString();

                    feed.fatPercentage = feeds[0].fatPercentage;
                    feed.animalCategories = feeds[0].animalCategories;
                    feed.remarks = "Required";

                    if (feedResult.Count == 0)
                    {
                        feedResult.Add(feed);
                    }
                    else
                    {
                        feedResult[1].dm = (Convert.ToDecimal(feedResult[1].dm) + Convert.ToDecimal(feed.dm) - Convert.ToDecimal(generalNutrition.dm)).ToString();
                        feedResult[1].tdn = (Convert.ToDecimal(feedResult[1].tdn) + Convert.ToDecimal(feed.tdn) - Convert.ToDecimal(generalNutrition.tdn)).ToString();
                        feedResult[1].p = (Convert.ToDecimal(feedResult[1].p) + Convert.ToDecimal(feed.p) -  Convert.ToDecimal(generalNutrition.p)).ToString();
                        feedResult[1].c = (Convert.ToDecimal(feedResult[1].c) + Convert.ToDecimal(feed.c) -  Convert.ToDecimal(generalNutrition.c)).ToString();

                    }
                }
            }

            if ((feeds[0].milkvolumn ?? "0") == "0")
            {
                feeds[0].milkvolumn = "1";
            }
            feedResult[0].p= (Convert.ToDecimal(feeds[0].p) * Convert.ToDecimal(1000)).ToString();
            feedResult[0].c = (Convert.ToDecimal(feeds[0].c) * Convert.ToDecimal(1000)).ToString();

            feedResult[1].dm = (Convert.ToDecimal(feeds[0].milkvolumn) * Convert.ToDecimal(feedResult[1].dm)).ToString();
            feedResult[1].tdn = (Convert.ToDecimal(feeds[0].milkvolumn) * Convert.ToDecimal(feedResult[1].tdn)).ToString();
            feedResult[1].p = ((Convert.ToDecimal(feeds[0].milkvolumn) * Convert.ToDecimal(feedResult[1].p))*Convert.ToDecimal(1000)).ToString();
            feedResult[1].c = ((Convert.ToDecimal(feeds[0].milkvolumn) * Convert.ToDecimal(feedResult[1].c))*Convert.ToDecimal(1000)).ToString();

            FeedCalculator feed2 = new FeedCalculator();
            feed2.dm = (Convert.ToDecimal(feedResult[0].dm) - Convert.ToDecimal(feedResult[1].dm)).ToString("0.00");
            feed2.c =( (Convert.ToDecimal(feedResult[0].c) - Convert.ToDecimal(feedResult[1].c))).ToString("0.00");
            feed2.p =( (Convert.ToDecimal(feedResult[0].p) - Convert.ToDecimal(feedResult[1].p))).ToString("0.00");
            feed2.tdn = (Convert.ToDecimal(feedResult[0].tdn) -  Convert.ToDecimal(feedResult[1].tdn)).ToString("0.00");
            feed2.fatPercentage = feeds[0].fatPercentage;
            feed2.category = feeds[0].category;
            feed2.remarks = "Result";
            feedResult.Add(feed2);

            return View(feedResult);
        }



        [HttpGet]
        public IActionResult milkBaseCalculation()
        {
            List<FeedCalculator> fooders = new List<FeedCalculator>();

            IEnumerable<FeedFooder> feedCategories = _repoU.FeedFooder.GetCategories();

            foreach (FeedFooder item in feedCategories)
            {
                FeedCalculator fooder1 = new FeedCalculator();
                fooder1.feedCategory = item.category;
                fooder1.feeds = new SelectList(_repoU.FeedFooder.GetByCategory(item.category), "id", "fooderNameEng");
                fooder1.animalCategories = new SelectList(_repoU.Species.GetModel(), "id", "speciesName");
                fooder1.fatPercentage = 0;
                fooder1.category = "";
                fooder1.weight = 0;
                fooder1.animalWeight = 0;
                fooder1.milkvolumn = "0";

                fooders.Add(fooder1);
            }

            return View(fooders);
        }
        [HttpPost]
        public IActionResult milkBaseCalculation(List<FeedCalculator> feeds)
        {
            List<FeedCalculator> feedResult = new List<FeedCalculator>();
            string fat = feeds[0].fatPercentage.ToString();
            string type = feeds[0].milk;
            string preg = feeds[0].pregnancy;
            string volumn = feeds[0].milkvolumn;
            string species = feeds[0].species;
            string speciesName = _repoU.Species.GetById(int.Parse(species)).speciesName;

            GeneralNutration generalNutrition = new GeneralNutration();
            MIlkBaseNutrition MilkBase = new MIlkBaseNutrition();
            PregnancyBaseNutrition PregancyBase = new PregnancyBaseNutrition();

            for (int i = 0; i < feeds.Count; i++)
            {
                if (feedResult.Count == 0 && (feeds[i].feedId.ToString() != "" && feeds[i].feedId != 0))
                {
                    FeedFooder fooder = _repoU.FeedFooder.GetById(feeds[i].feedId);
                    FeedCalculator feed1 = new FeedCalculator();
                    feed1.dm = (Convert.ToDecimal(feeds[i].weight) * Convert.ToDecimal(fooder.dm) * Convert.ToDecimal(.01)).ToString("0.00");
                    feed1.c = (Convert.ToDecimal(feeds[i].weight) * Convert.ToDecimal(fooder.c) * Convert.ToDecimal(10)).ToString("0.00");
                    feed1.p = (Convert.ToDecimal(feeds[i].weight) * Convert.ToDecimal(fooder.p) * Convert.ToDecimal(10)).ToString("0.00");
                    feed1.tdn = (Convert.ToDecimal(feeds[i].weight) * Convert.ToDecimal(fooder.tdn) * Convert.ToDecimal(0.01)).ToString("0.00");
                    feed1.dcp = (Convert.ToDecimal(feeds[i].weight) * Convert.ToDecimal(fooder.dm) * Convert.ToDecimal(10)).ToString("0.00");
                    feed1.me = (Convert.ToDecimal(feeds[i].weight) * Convert.ToDecimal(fooder.dm) * Convert.ToDecimal(10)).ToString("0.00");
                    feed1.fatPercentage = feeds[0].fatPercentage;
                    feed1.animalWeight = feeds[0].animalWeight;
                    feed1.animalCategories = feeds[0].animalCategories;
                    feed1.remarks = "Feed Fooder";

                    feedResult.Add(feed1);
                }
                else if (feedResult.Any() && feeds[i].feedId.ToString() != "" && feeds[i].feedId != 0)
                {
                    FeedFooder fooder = _repoU.FeedFooder.GetById(feeds[i].feedId);
                    feedResult[0].dm = (Convert.ToDecimal(feedResult[0].dm) + Convert.ToDecimal(feeds[i].weight) * Convert.ToDecimal(fooder.dm) * Convert.ToDecimal(0.01)).ToString("0.00");
                    feedResult[0].c = (Convert.ToDecimal(feedResult[0].c) + Convert.ToDecimal(feeds[i].weight) * Convert.ToDecimal(fooder.c) * Convert.ToDecimal(10)).ToString("0.00");
                    feedResult[0].p = (Convert.ToDecimal(feedResult[0].p) + Convert.ToDecimal(feeds[i].weight) * Convert.ToDecimal(fooder.p) * Convert.ToDecimal(10)).ToString("0.00");
                    feedResult[0].tdn = (Convert.ToDecimal(feedResult[0].tdn) + Convert.ToDecimal(feeds[i].weight) * Convert.ToDecimal(fooder.tdn) * Convert.ToDecimal(0.01)).ToString("0.00");
                    feedResult[0].dcp = (Convert.ToDecimal(feedResult[0].dcp) + Convert.ToDecimal(feeds[i].weight) * Convert.ToDecimal(fooder.dm) * Convert.ToDecimal(0.01)).ToString("0.00");
                    feedResult[0].me = (Convert.ToDecimal(feedResult[0].me) + Convert.ToDecimal(feeds[i].weight) * Convert.ToDecimal(fooder.dm) * Convert.ToDecimal(0.01)).ToString("0.00");

                }
            }

            {
                MilkBase = _repoU.MilkBase.GetByFat(fat, int.Parse(species));
                if (MilkBase == null)
                {
                    ModelState.AddModelError(string.Empty, "Milk Base Record Not Found.");
                    feeds[0].feeds = new SelectList(_repoU.FeedFooder.GetModel(), "id", "fooderNameEng", feeds[0].feedId);
                    feeds[0].animalCategories = new SelectList(_repoU.Species.GetModel(), "speciesName", "speciesName", feeds[0].category);
                    return View(feeds);
                }
                calculate cal = new calculate();
                string[] dm = cal.CalculateDm(feeds[0].animalWeight.ToString(),"",feeds[0].milkvolumn);

                FeedCalculator feed = new FeedCalculator();
                feed.dm = (Convert.ToDecimal(dm[0])).ToString();
                feed.tdn = ( Convert.ToDecimal(MilkBase.tdn)).ToString();
                feed.p = ( Convert.ToDecimal(MilkBase.p)).ToString();
                feed.c = ( Convert.ToDecimal(MilkBase.c)).ToString();
                feed.fatPercentage = feeds[0].fatPercentage;
                feed.category = feeds[0].category;
                feed.animalWeight = feeds[0].animalWeight;
                feed.remarks = "Required";
                feedResult.Add(feed);

            }
            
            if ((feeds[0].milkvolumn ?? "0") == "0")
            {
                feeds[0].milkvolumn = "10";
            }
            //feedResult[0].p = (Convert.ToDecimal(feeds[0].p) 00)).ToString();
            //feedResult[0].c = (Convert.ToDecimal(feeds[0].c) * Convert.ToDecimal(1000)).ToString();

            //feedResult[1].dm = (Convert.ToDecimal(feeds[0].milkvolumn) * Convert.ToDecimal(feedResult[1].dm)).ToString();
            //feedResult[1].tdn = (Convert.ToDecimal(feeds[0].milkvolumn) * Convert.ToDecimal(feedResult[1].tdn)).ToString();
            //feedResult[1].p = ((Convert.ToDecimal(feeds[0].milkvolumn) * Convert.ToDecimal(feedResult[1].p))).ToString();
            //feedResult[1].c = ((Convert.ToDecimal(feeds[0].milkvolumn) * Convert.ToDecimal(feedResult[1].c))).ToString();

            FeedCalculator feed2 = new FeedCalculator();
            feed2.dm = (Convert.ToDecimal(feedResult[0].dm) - Convert.ToDecimal(feedResult[1].dm)).ToString("0.00");
            feed2.c = ((Convert.ToDecimal(feedResult[0].c) - Convert.ToDecimal(feedResult[1].c))).ToString("0.00");
            feed2.p = ((Convert.ToDecimal(feedResult[0].p) - Convert.ToDecimal(feedResult[1].p))).ToString("0.00");
            feed2.tdn = (Convert.ToDecimal(feedResult[0].tdn) - Convert.ToDecimal(feedResult[1].tdn)).ToString("0.00");
            feed2.fatPercentage = feeds[0].fatPercentage;
            feed2.category = feeds[0].category;
            feed2.remarks = "Result";
            feedResult.Add(feed2);

            return View(feedResult);
        }




    }
}