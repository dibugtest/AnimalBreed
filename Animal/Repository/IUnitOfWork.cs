using Animal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animal.Repository
{
    public interface IUnitOfWork :IDisposable
    {
         IAnimalRepository AnimalRegistration { get; }
         IBreedRepository Breed { get; }
         IOwnerRepository OwnerKeeper { get; }
       
         IFarmReository Farm { get; }
         IFeedRepository FeedFooder { get; }
        IMilkBaseNutritionRepository MilkBase { get; }
        IMilkRecordRepository MilkRecord { get; }
        IPregnencyNutritionRepository PregnancyBaseNutrition { get; }
        ISpeciesRepository Species { get; }
        ILabRepository labs { get; }
        IKeeperRepository keepers{ get; }
        IGeneralNutritionRepository GeneralNutrition { get; }

        IEarTagRepository EarTag { get; }
        IGoatBreedRepository GoatBreed { get; }
        IGoatRepository GoatRegistration { get; }

        IVaccinationTypeRepository VaccinationTypes { get; }
        IVaccinationSubTypeRepository VaccinationSubTypes { get; }
        IVaccinationRepository Vaccinations { get; }
        IVaccinationAnimalRepository VaccinationAnimals { get; }
        IDiseasesRepository Diseases { get; }
        IAiRepository Ais { get; }


        void Save();
    }
}
