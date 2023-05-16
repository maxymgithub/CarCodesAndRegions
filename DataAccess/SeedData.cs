using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class SeedData
    {
        public static void SeedRegions(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Region>().HasData(new Region[]
            {
                new Region() { Id = 1, RegionName="Київ"},
                new Region() { Id = 2, RegionName="Вінницька"},
                new Region() { Id = 3, RegionName="Волинська"},
                new Region() { Id = 4, RegionName="Дніпропетровська"},
                new Region() { Id = 5, RegionName="Донецька"},
                new Region() { Id = 6, RegionName="Київська"},
                new Region() { Id = 7, RegionName="Житомирська"},
                new Region() { Id = 8, RegionName="Закарпатська"},
                new Region() { Id = 9, RegionName="Запорізька"},
                new Region() { Id = 10, RegionName="Івано-Франківська"},
                new Region() { Id = 11, RegionName="Харківська"},
                new Region() { Id = 12, RegionName="Кіровоградська"},
                new Region() { Id = 13, RegionName="Луганська"},
                new Region() { Id = 14, RegionName="Львівська"},
                new Region() { Id = 15, RegionName="Миколаївська"},
                new Region() { Id = 16, RegionName="Одеська"},
                new Region() { Id = 17, RegionName="Полтавська"},
                new Region() { Id = 18, RegionName="Рівненська"},
                new Region() { Id = 19, RegionName="Сумська"},
                new Region() { Id = 20, RegionName="Тернопільська"},
                new Region() { Id = 21, RegionName="Херсонська"},
                new Region() { Id = 22, RegionName="Хмельницька"},
                new Region() { Id = 23, RegionName="Черкаська"},
                new Region() { Id = 24, RegionName="Чернігівська"},
                new Region() { Id = 25, RegionName="Чернівецька"},
                new Region() { Id = 26, RegionName="Загальнодержавна серія"}
            });
        }
        public static void SeedRegionCodes(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarNumberCode>().HasData(new CarNumberCode[]
            {
                new CarNumberCode() { Id = 1, RegionCode="AA", RegionId=1},
                new CarNumberCode() { Id = 2, RegionCode="KA", RegionId=1},
                new CarNumberCode() { Id = 3, RegionCode="AB", RegionId=2},
                new CarNumberCode() { Id = 4, RegionCode="KB", RegionId=2},
                new CarNumberCode() { Id = 5, RegionCode="AC", RegionId=3},
                new CarNumberCode() { Id = 6, RegionCode="KC", RegionId=3},
                new CarNumberCode() { Id = 7, RegionCode="AE", RegionId=4},
                new CarNumberCode() { Id = 8, RegionCode="KE", RegionId=4},
                new CarNumberCode() { Id = 9, RegionCode="AH", RegionId=5},
                new CarNumberCode() { Id = 10, RegionCode="KH", RegionId=5},
                new CarNumberCode() { Id = 11, RegionCode="AI", RegionId=6},
                new CarNumberCode() { Id = 12, RegionCode="KI", RegionId=6},
                new CarNumberCode() { Id = 13, RegionCode="AM", RegionId=7},
                new CarNumberCode() { Id = 14, RegionCode="KM", RegionId=7},
                new CarNumberCode() { Id = 15, RegionCode="AO", RegionId=8},
                new CarNumberCode() { Id = 16, RegionCode="KO", RegionId=8},
                new CarNumberCode() { Id = 17, RegionCode="AP", RegionId=9},
                new CarNumberCode() { Id = 18, RegionCode="KP", RegionId=9},
                new CarNumberCode() { Id = 19, RegionCode="AT", RegionId=10},
                new CarNumberCode() { Id = 20, RegionCode="KT", RegionId=10},
                new CarNumberCode() { Id = 21, RegionCode="AX", RegionId=11},
                new CarNumberCode() { Id = 22, RegionCode="KX", RegionId=11},
                new CarNumberCode() { Id = 23, RegionCode="BA", RegionId=12},
                new CarNumberCode() { Id = 24, RegionCode="HA", RegionId=12},
                new CarNumberCode() { Id = 25, RegionCode="BB", RegionId=13},
                new CarNumberCode() { Id = 26, RegionCode="HB", RegionId=13},
                new CarNumberCode() { Id = 27, RegionCode="BC", RegionId=14},
                new CarNumberCode() { Id = 28, RegionCode="HC", RegionId=14},
                new CarNumberCode() { Id = 29, RegionCode="BE", RegionId=15},
                new CarNumberCode() { Id = 30, RegionCode="HE", RegionId=15},
                new CarNumberCode() { Id = 31, RegionCode="BH", RegionId=16},
                new CarNumberCode() { Id = 32, RegionCode="HH", RegionId=16},
                new CarNumberCode() { Id = 33, RegionCode="BI", RegionId=17},
                new CarNumberCode() { Id = 34, RegionCode="HI", RegionId=17},
                new CarNumberCode() { Id = 35, RegionCode="BK", RegionId=18},
                new CarNumberCode() { Id = 36, RegionCode="HK", RegionId=18},
                new CarNumberCode() { Id = 37, RegionCode="BM", RegionId=19},
                new CarNumberCode() { Id = 38, RegionCode="HM", RegionId=19},
                new CarNumberCode() { Id = 39, RegionCode="BO", RegionId=20},
                new CarNumberCode() { Id = 40, RegionCode="HO", RegionId=20},
                new CarNumberCode() { Id = 41, RegionCode="BT", RegionId=21},
                new CarNumberCode() { Id = 42, RegionCode="HT", RegionId=21},
                new CarNumberCode() { Id = 43, RegionCode="BX", RegionId=22},
                new CarNumberCode() { Id = 44, RegionCode="HX", RegionId=22},
                new CarNumberCode() { Id = 45, RegionCode="CA", RegionId=23},
                new CarNumberCode() { Id = 46, RegionCode="IA", RegionId=23},
                new CarNumberCode() { Id = 47, RegionCode="CB", RegionId=24},
                new CarNumberCode() { Id = 48, RegionCode="IB", RegionId=24},
                new CarNumberCode() { Id = 49, RegionCode="CE", RegionId=25},
                new CarNumberCode() { Id = 50, RegionCode="IE", RegionId=25},
                new CarNumberCode() { Id = 51, RegionCode="II", RegionId=26},
            });
        }
    }
}
