using TsSoft.Dapper.QueryBuilder.Metadata;
using TsSoft.Dapper.QueryBuilder.Models;
using TsSoft.Dapper.QueryBuilder.Models.Enumerations;

namespace WinFormsTestApp.Criterias
{
    [Table("Houses")]
    public class HouseCriteria : Criteria
    {
        [Where]
        public int? Id { get; set; }

        [Where]
        public int? OwnerId { get; set; }

        [Where("Price", WhereType = WhereType.GtEq)]
        public long? PriceFrom { get; set; }

        [Where("Price", WhereType = WhereType.LtEq)]
        public long? PriceTo { get; set; }

        [Where("Persons", TableName = "Persons", WhereType = WhereType.Like)]
        [ManyToManyJoin("HouseId", JoinType.Left, "Pesons", "HousesPersons", "HouseId", "PersonId", NoSplit = true,
            Including = "WithPersons", SelectColumns = "Persons:")]
        public string PersonFullName { get; set; }

        [ManyToManyJoin("HouseId", JoinType.Left, "Pesons", "HousesPersons", "HouseId", "PersonId",
            SelectColumns = "Persons:FullName;HousesPersons:Registration")]
        public bool WithPersons { get; set; }
    }
}