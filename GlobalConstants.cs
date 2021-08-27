namespace DriveSupport
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public static class GlobalConstants
    {
        //----------------------------Common-------------------------------//
        public const string SystemName = "DriveSupport";

        public const string AdministratorRoleName = "Administrator";

        //----------------------------Sorting-------------------------------//
        public const string SortingCheapestName = "Cheapest";
        public const string SortingExpensivestName = "Expensivest";
        public const string SortingOldestName = "Oldest";
        public const string SortingNewestName = "Newest";
        public const string SortingLessViewedName = "Less Viewed";
        public const string SortingMostViewedName = "Most Viewed";

        //----------------------------Categories-------------------------------//
        public const string LegoCategoryName = "Lego";
        public const string HotWheelsCategoryName = "Hot Wheels";

        //----------------------------User-------------------------------//
        public const byte UsernameMinLength = 2;
        public const byte UsernameMaxLength = 24;


    }
}
