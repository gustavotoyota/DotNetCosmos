using MongoDB.Bson.Serialization.Attributes;

namespace DataWithMongoDB.Models
{
    /*
     * BsonIgnoreExtraElements: Ignores extra elements in the document that don't map to the class
     */

    [BsonIgnoreExtraElements]

    /*
     * BsonDiscriminator: Configures the discriminator for a class hierarchy
     * 
     * Enables class inheritance mapping
     * This is used to store different derived classes in the same MongoDB collection
     */

    [BsonDiscriminator]
    public class SchemaAnnotations
    {
        /*
         * BsonId: Indicates the primary key field
         */

        [BsonId]
        public required string Id { get; set; }

        /*
         * BsonElement: Maps the property to a specific field name in the MongoDB document
         * 
         * Useful if the property name doesn't match the desired name in the database
         * - elementName: The name of the property in the document
         * - Order: The order in which the property appears in the document
         */

        [BsonElement("name")]
        public required string Name { get; set; }

        /*
         * BsonRepresentation: Controls how a C# data type is stored within the BSON document
         * 
         * Options include:
         * - BsonType.ObjectId
         * - BsonType.String
         * - BsonType.Int32
         * - BsonType.Int64
         * - BsonType.DateTime
         * - And more...
         */

        [BsonRepresentation(MongoDB.Bson.BsonType.Decimal128)]
        public decimal Price { get; set; }

        /*
         * BsonIgnore: Excludes the property from the database
         */

        [BsonIgnore]
        public required string NotMappedProperty { get; set; }

        /*
         * BsonIgnoreIfNull: Excludes the property from the database if the value is null
         */

        [BsonIgnoreIfNull]
        public required string NotMappedIfNullProperty { get; set; }

        /*
         * BsonIgnoreIfDefault: Excludes the property from the database if the value is the default value
         */

        [BsonIgnoreIfDefault]
        public required string NotMappedIfDefaultProperty { get; set; }

        /*
         * BsonDateTimeOptions: Configures how DateTime values are serialized to BSON
         * 
         * Options include:
         * - DateOnly: Indicates whether to serialize the DateTime value as a date only
         * - Kind: Indicates the DateTimeKind of the DateTime value
         *   - DateTimeKind.Unspecified
         *   - DateTimeKind.Local
         *   - DateTimeKind.Utc
         * - Representation: The BSON representation for the DateTime value
         */

        [BsonDateTimeOptions(DateOnly = true)]
        public DateTime CreatedDate { get; set; }

        /*
         * BsonRequired: Marks a property as required, meaning it cannot be null when saved to MongoDB
         */

        [BsonRequired]
        public required string RequiredProperty { get; set; }
    }
}
