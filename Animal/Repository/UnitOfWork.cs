﻿using Animal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animal.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private AnimalContext _repoContext;


        //public IAnimalRepository _animal;
        //public IBreedRepository _breed;
        //public IOwnerRepository _owner;
        //public IFarmRepository _farm;
        //public IFeedRepository _feed;

        public UnitOfWork(AnimalContext repositoryContext)
        {
            _repoContext = repositoryContext;
            AnimalRegistration = new AnimalRepository(_repoContext);
            Breed = new BreedRepository(_repoContext);
            OwnerKeeper = new OwnerRepository(_repoContext);
            FeedFooder = new FeedRepository(_repoContext);
            Farm = new FarmRepository(_repoContext);
            MilkBase = new MilkBaseNutritionRepository(_repoContext);
            MilkRecord = new MilkRecordRepository(_repoContext);
            PregnancyBaseNutrition = new PregnencyNutritionRepository(_repoContext);
            Species = new SpeciesReporitory(_repoContext);
            EarTag = new EarTagRepository(_repoContext);
            labs = new labRepository(_repoContext);
            keepers = new keeperRepository(_repoContext);
            GeneralNutrition = new GeneralNutritionRepository(_repoContext);
            GoatBreed = new GoatBreedReporitory(_repoContext);
            GoatRegistration = new GoatRepository(_repoContext);
            VaccinationTypes = new VaccinationTypeRepository(_repoContext);
            VaccinationSubTypes = new VaccinationSubTypeRepository(_repoContext);
            Vaccinations = new VaccinationRepository(_repoContext);
            VaccinationAnimals = new VaccinationAnimalRepository(_repoContext);
            Diseases = new DiseasesRepository(_repoContext);
            Ais = new AiRepository(_repoContext);
        }



        public IAiRepository Ais
        {
            get; private set;
        }
        public IVaccinationTypeRepository VaccinationTypes
        {
            get; private set;
        }
        public IDiseasesRepository Diseases
        {
            get; private set;
        }
        public IVaccinationSubTypeRepository VaccinationSubTypes
        {
            get; private set;
        }
        public IVaccinationRepository Vaccinations
        {
            get; private set;
        }
        public IVaccinationAnimalRepository VaccinationAnimals
        {
            get; private set;
        }
        public IGoatBreedRepository GoatBreed
        {
            get; private set;
        }
        public IGoatRepository GoatRegistration
        {
            get; private set;
        }
        public IGeneralNutritionRepository GeneralNutrition
        {
            get; private set;
        }

        public ISpeciesRepository Species
        {
            get; private set;
        }
        public IMilkRecordRepository MilkRecord
        {
            get; private set;
        }
        public IMilkBaseNutritionRepository MilkBase
        {
            get; private set;
        }
        public IAnimalRepository AnimalRegistration
        {

            get; private set;
        }

        public IBreedRepository Breed
        {
            get; private set;
        }

        public IOwnerRepository OwnerKeeper
        {
            get; private set;
        }
        public IFarmReository Farm
        {
            get; private set;
        }
        public IFeedRepository FeedFooder
        {
            get; private set;
        }
        public IPregnencyNutritionRepository PregnancyBaseNutrition
        {
            get; private set;
        }

        public IEarTagRepository EarTag
        {
            get; private set;
        }

        public ILabRepository labs
        {
            get; private set;
        }

        public IKeeperRepository keepers
        {
            get; private set;
        }

        public void Save()
        {
            _repoContext.SaveChanges();
        }







        //public new IAnimalRepository AnimalRegistration
        //{
        //    get; private set;
        //}

        //public new IBreedRepository Breed
        //{
        //    get; private set;
        //}

        //public new IOwnerRepository OwnerKeeper
        //{
        //    get; private set;
        //}
        //public new IFarmRepository Farm
        //{
        //    get; private set;
        //}
        //public new IFeedRepository FeedFooder
        //{
        //    get; private set;
        //}


        public void Dispose()
        {
            _repoContext.Dispose();
        }

    }
}