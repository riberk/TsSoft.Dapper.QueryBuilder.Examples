using TsSoft.Dapper.QueryBuilder.Metadata;
using TsSoft.Dapper.QueryBuilder.Models;
using TsSoft.Dapper.QueryBuilder.Models.Enumerations;

namespace WinFormsTestApp.Criterias
{
    // Критерия выборки из таблицы Houses
    [Table("Houses")]
    public class HouseCriteria : Criteria
    {
        // Простой метод where. Трансформируется в Where Houses.HouseId = @HousesHouseId,
        // где @HousesHouseId == значению int? HouseId критерии. Если в критериии null - не включается в отбор
        [Where]
        public int? HouseId { get; set; }

        [Where]
        public int? OwnerId { get; set; }

        // Where Houses.Price >= @HousesPriceFrom
        [Where("Price", WhereType = WhereType.GtEq)]
        public long? PriceFrom { get; set; }

        // Where Houses.Price <= @HousesPriceFrom
        [Where("Price", WhereType = WhereType.LtEq)]
        public long? PriceTo { get; set; }

        // select ... , 0 as SplitOnOwnersOwnerId , Owners.* , ...
        // ... Inner join Owners on Owners.OwnerId = Houses.OwnerId ...
        [SimpleJoin("OwnerId", JoinType.Inner, "Owners")]
        public bool WithOwner { get; set; }

        // select ... , 0 as SplitOnPesonsHouseId, Persons.FullName , HousesPersons.Registration , ...
        // ... Left Join HousesPersons on HousesPersons.HouseId = Houses.HouseId
        //     Left Join Pesons on Pesons.PersonId = HousesPersons.PersonId
        [ManyToManyJoin("HouseId", JoinType.Left, "Pesons", "HousesPersons", "HouseId", "PersonId",
            SelectColumns = "Persons:FullName;HousesPersons:Registration")]
        public bool WithPersons { get; set; }

        // Where Persons.FullName Like @PersonsFullName
        [Where("FullName", TableName = "Persons", WhereType = WhereType.Like)]
        // NoSplit - не создавать разделитель, 
        // Including - не делать джойн, если он уже сделан (WithPersons = true)
        // SelectColumns - какие столбцы выбирать ("Person:" - не выбирать никаких)
        [ManyToManyJoin("HouseId", JoinType.Left, "Pesons", "HousesPersons", "HouseId", "PersonId", NoSplit = true,
            Including = "WithPersons", SelectColumns = "Persons:")]
        public string PersonFullName { get; set; }
    }
}