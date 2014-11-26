

// This file was automatically generated.
// Do not make changes directly to this file - edit the template instead.
// 
// The following connection settings were used to generate this file
// 
//     Configuration file:     "WebApplication\Web.config"
//     Connection String Name: "AdventureWorks"
//     Connection String:      "Server=.\SQL2012;Database=AdventureWorks;Integrated Security=True"

// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
//using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.DatabaseGeneratedOption;
using System.Data.Entity.Hierarchy;

namespace WebApplication.Data
{
    // ************************************************************************
    // Unit of work
    public interface IAdventureWorksContext : IDisposable
    {
        IDbSet<HumanResourcesDepartment> HumanResourcesDepartment { get; set; } // Department
        IDbSet<HumanResourcesEmployee> HumanResourcesEmployee { get; set; } // Employee
        IDbSet<HumanResourcesEmployeeDepartmentHistory> HumanResourcesEmployeeDepartmentHistory { get; set; } // EmployeeDepartmentHistory
        IDbSet<HumanResourcesEmployeePayHistory> HumanResourcesEmployeePayHistory { get; set; } // EmployeePayHistory
        IDbSet<HumanResourcesJobCandidate> HumanResourcesJobCandidate { get; set; } // JobCandidate
        IDbSet<HumanResourcesShift> HumanResourcesShift { get; set; } // Shift
        IDbSet<PersonAddress> PersonAddress { get; set; } // Address
        IDbSet<PersonAddressType> PersonAddressType { get; set; } // AddressType
        IDbSet<PersonBusinessEntity> PersonBusinessEntity { get; set; } // BusinessEntity
        IDbSet<PersonBusinessEntityAddress> PersonBusinessEntityAddress { get; set; } // BusinessEntityAddress
        IDbSet<PersonBusinessEntityContact> PersonBusinessEntityContact { get; set; } // BusinessEntityContact
        IDbSet<PersonContactType> PersonContactType { get; set; } // ContactType
        IDbSet<PersonCountryRegion> PersonCountryRegion { get; set; } // CountryRegion
        IDbSet<PersonEmailAddress> PersonEmailAddress { get; set; } // EmailAddress
        IDbSet<PersonPassword> PersonPassword { get; set; } // Password
        IDbSet<PersonPerson> PersonPerson { get; set; } // Person
        IDbSet<PersonPersonPhone> PersonPersonPhone { get; set; } // PersonPhone
        IDbSet<PersonPhoneNumberType> PersonPhoneNumberType { get; set; } // PhoneNumberType
        IDbSet<PersonStateProvince> PersonStateProvince { get; set; } // StateProvince
        IDbSet<ProductionBillOfMaterials> ProductionBillOfMaterials { get; set; } // BillOfMaterials
        IDbSet<ProductionCulture> ProductionCulture { get; set; } // Culture
        IDbSet<ProductionDocument> ProductionDocument { get; set; } // Document
        IDbSet<ProductionIllustration> ProductionIllustration { get; set; } // Illustration
        IDbSet<ProductionLocation> ProductionLocation { get; set; } // Location
        IDbSet<ProductionProduct> ProductionProduct { get; set; } // Product
        IDbSet<ProductionProductCategory> ProductionProductCategory { get; set; } // ProductCategory
        IDbSet<ProductionProductCostHistory> ProductionProductCostHistory { get; set; } // ProductCostHistory
        IDbSet<ProductionProductDescription> ProductionProductDescription { get; set; } // ProductDescription
        IDbSet<ProductionProductDocument> ProductionProductDocument { get; set; } // ProductDocument
        IDbSet<ProductionProductInventory> ProductionProductInventory { get; set; } // ProductInventory
        IDbSet<ProductionProductListPriceHistory> ProductionProductListPriceHistory { get; set; } // ProductListPriceHistory
        IDbSet<ProductionProductModel> ProductionProductModel { get; set; } // ProductModel
        IDbSet<ProductionProductModelIllustration> ProductionProductModelIllustration { get; set; } // ProductModelIllustration
        IDbSet<ProductionProductModelProductDescriptionCulture> ProductionProductModelProductDescriptionCulture { get; set; } // ProductModelProductDescriptionCulture
        IDbSet<ProductionProductPhoto> ProductionProductPhoto { get; set; } // ProductPhoto
        IDbSet<ProductionProductProductPhoto> ProductionProductProductPhoto { get; set; } // ProductProductPhoto
        IDbSet<ProductionProductReview> ProductionProductReview { get; set; } // ProductReview
        IDbSet<ProductionProductSubcategory> ProductionProductSubcategory { get; set; } // ProductSubcategory
        IDbSet<ProductionScrapReason> ProductionScrapReason { get; set; } // ScrapReason
        IDbSet<ProductionTransactionHistory> ProductionTransactionHistory { get; set; } // TransactionHistory
        IDbSet<ProductionTransactionHistoryArchive> ProductionTransactionHistoryArchive { get; set; } // TransactionHistoryArchive
        IDbSet<ProductionUnitMeasure> ProductionUnitMeasure { get; set; } // UnitMeasure
        IDbSet<ProductionWorkOrder> ProductionWorkOrder { get; set; } // WorkOrder
        IDbSet<ProductionWorkOrderRouting> ProductionWorkOrderRouting { get; set; } // WorkOrderRouting
        IDbSet<PurchasingProductVendor> PurchasingProductVendor { get; set; } // ProductVendor
        IDbSet<PurchasingPurchaseOrderDetail> PurchasingPurchaseOrderDetail { get; set; } // PurchaseOrderDetail
        IDbSet<PurchasingPurchaseOrderHeader> PurchasingPurchaseOrderHeader { get; set; } // PurchaseOrderHeader
        IDbSet<PurchasingShipMethod> PurchasingShipMethod { get; set; } // ShipMethod
        IDbSet<PurchasingVendor> PurchasingVendor { get; set; } // Vendor
        IDbSet<SalesCountryRegionCurrency> SalesCountryRegionCurrency { get; set; } // CountryRegionCurrency
        IDbSet<SalesCreditCard> SalesCreditCard { get; set; } // CreditCard
        IDbSet<SalesCurrency> SalesCurrency { get; set; } // Currency
        IDbSet<SalesCurrencyRate> SalesCurrencyRate { get; set; } // CurrencyRate
        IDbSet<SalesCustomer> SalesCustomer { get; set; } // Customer
        IDbSet<SalesPersonCreditCard> SalesPersonCreditCard { get; set; } // PersonCreditCard
        IDbSet<SalesSalesOrderDetail> SalesSalesOrderDetail { get; set; } // SalesOrderDetail
        IDbSet<SalesSalesOrderHeader> SalesSalesOrderHeader { get; set; } // SalesOrderHeader
        IDbSet<SalesSalesOrderHeaderSalesReason> SalesSalesOrderHeaderSalesReason { get; set; } // SalesOrderHeaderSalesReason
        IDbSet<SalesSalesPerson> SalesSalesPerson { get; set; } // SalesPerson
        IDbSet<SalesSalesPersonQuotaHistory> SalesSalesPersonQuotaHistory { get; set; } // SalesPersonQuotaHistory
        IDbSet<SalesSalesReason> SalesSalesReason { get; set; } // SalesReason
        IDbSet<SalesSalesTaxRate> SalesSalesTaxRate { get; set; } // SalesTaxRate
        IDbSet<SalesSalesTerritory> SalesSalesTerritory { get; set; } // SalesTerritory
        IDbSet<SalesSalesTerritoryHistory> SalesSalesTerritoryHistory { get; set; } // SalesTerritoryHistory
        IDbSet<SalesShoppingCartItem> SalesShoppingCartItem { get; set; } // ShoppingCartItem
        IDbSet<SalesSpecialOffer> SalesSpecialOffer { get; set; } // SpecialOffer
        IDbSet<SalesSpecialOfferProduct> SalesSpecialOfferProduct { get; set; } // SpecialOfferProduct
        IDbSet<SalesStore> SalesStore { get; set; } // Store

        int SaveChanges();
    }

    // ************************************************************************
    // Database context
    public class AdventureWorksContext : DbContext, IAdventureWorksContext
    {
        public IDbSet<HumanResourcesDepartment> HumanResourcesDepartment { get; set; } // Department
        public IDbSet<HumanResourcesEmployee> HumanResourcesEmployee { get; set; } // Employee
        public IDbSet<HumanResourcesEmployeeDepartmentHistory> HumanResourcesEmployeeDepartmentHistory { get; set; } // EmployeeDepartmentHistory
        public IDbSet<HumanResourcesEmployeePayHistory> HumanResourcesEmployeePayHistory { get; set; } // EmployeePayHistory
        public IDbSet<HumanResourcesJobCandidate> HumanResourcesJobCandidate { get; set; } // JobCandidate
        public IDbSet<HumanResourcesShift> HumanResourcesShift { get; set; } // Shift
        public IDbSet<PersonAddress> PersonAddress { get; set; } // Address
        public IDbSet<PersonAddressType> PersonAddressType { get; set; } // AddressType
        public IDbSet<PersonBusinessEntity> PersonBusinessEntity { get; set; } // BusinessEntity
        public IDbSet<PersonBusinessEntityAddress> PersonBusinessEntityAddress { get; set; } // BusinessEntityAddress
        public IDbSet<PersonBusinessEntityContact> PersonBusinessEntityContact { get; set; } // BusinessEntityContact
        public IDbSet<PersonContactType> PersonContactType { get; set; } // ContactType
        public IDbSet<PersonCountryRegion> PersonCountryRegion { get; set; } // CountryRegion
        public IDbSet<PersonEmailAddress> PersonEmailAddress { get; set; } // EmailAddress
        public IDbSet<PersonPassword> PersonPassword { get; set; } // Password
        public IDbSet<PersonPerson> PersonPerson { get; set; } // Person
        public IDbSet<PersonPersonPhone> PersonPersonPhone { get; set; } // PersonPhone
        public IDbSet<PersonPhoneNumberType> PersonPhoneNumberType { get; set; } // PhoneNumberType
        public IDbSet<PersonStateProvince> PersonStateProvince { get; set; } // StateProvince
        public IDbSet<ProductionBillOfMaterials> ProductionBillOfMaterials { get; set; } // BillOfMaterials
        public IDbSet<ProductionCulture> ProductionCulture { get; set; } // Culture
        public IDbSet<ProductionDocument> ProductionDocument { get; set; } // Document
        public IDbSet<ProductionIllustration> ProductionIllustration { get; set; } // Illustration
        public IDbSet<ProductionLocation> ProductionLocation { get; set; } // Location
        public IDbSet<ProductionProduct> ProductionProduct { get; set; } // Product
        public IDbSet<ProductionProductCategory> ProductionProductCategory { get; set; } // ProductCategory
        public IDbSet<ProductionProductCostHistory> ProductionProductCostHistory { get; set; } // ProductCostHistory
        public IDbSet<ProductionProductDescription> ProductionProductDescription { get; set; } // ProductDescription
        public IDbSet<ProductionProductDocument> ProductionProductDocument { get; set; } // ProductDocument
        public IDbSet<ProductionProductInventory> ProductionProductInventory { get; set; } // ProductInventory
        public IDbSet<ProductionProductListPriceHistory> ProductionProductListPriceHistory { get; set; } // ProductListPriceHistory
        public IDbSet<ProductionProductModel> ProductionProductModel { get; set; } // ProductModel
        public IDbSet<ProductionProductModelIllustration> ProductionProductModelIllustration { get; set; } // ProductModelIllustration
        public IDbSet<ProductionProductModelProductDescriptionCulture> ProductionProductModelProductDescriptionCulture { get; set; } // ProductModelProductDescriptionCulture
        public IDbSet<ProductionProductPhoto> ProductionProductPhoto { get; set; } // ProductPhoto
        public IDbSet<ProductionProductProductPhoto> ProductionProductProductPhoto { get; set; } // ProductProductPhoto
        public IDbSet<ProductionProductReview> ProductionProductReview { get; set; } // ProductReview
        public IDbSet<ProductionProductSubcategory> ProductionProductSubcategory { get; set; } // ProductSubcategory
        public IDbSet<ProductionScrapReason> ProductionScrapReason { get; set; } // ScrapReason
        public IDbSet<ProductionTransactionHistory> ProductionTransactionHistory { get; set; } // TransactionHistory
        public IDbSet<ProductionTransactionHistoryArchive> ProductionTransactionHistoryArchive { get; set; } // TransactionHistoryArchive
        public IDbSet<ProductionUnitMeasure> ProductionUnitMeasure { get; set; } // UnitMeasure
        public IDbSet<ProductionWorkOrder> ProductionWorkOrder { get; set; } // WorkOrder
        public IDbSet<ProductionWorkOrderRouting> ProductionWorkOrderRouting { get; set; } // WorkOrderRouting
        public IDbSet<PurchasingProductVendor> PurchasingProductVendor { get; set; } // ProductVendor
        public IDbSet<PurchasingPurchaseOrderDetail> PurchasingPurchaseOrderDetail { get; set; } // PurchaseOrderDetail
        public IDbSet<PurchasingPurchaseOrderHeader> PurchasingPurchaseOrderHeader { get; set; } // PurchaseOrderHeader
        public IDbSet<PurchasingShipMethod> PurchasingShipMethod { get; set; } // ShipMethod
        public IDbSet<PurchasingVendor> PurchasingVendor { get; set; } // Vendor
        public IDbSet<SalesCountryRegionCurrency> SalesCountryRegionCurrency { get; set; } // CountryRegionCurrency
        public IDbSet<SalesCreditCard> SalesCreditCard { get; set; } // CreditCard
        public IDbSet<SalesCurrency> SalesCurrency { get; set; } // Currency
        public IDbSet<SalesCurrencyRate> SalesCurrencyRate { get; set; } // CurrencyRate
        public IDbSet<SalesCustomer> SalesCustomer { get; set; } // Customer
        public IDbSet<SalesPersonCreditCard> SalesPersonCreditCard { get; set; } // PersonCreditCard
        public IDbSet<SalesSalesOrderDetail> SalesSalesOrderDetail { get; set; } // SalesOrderDetail
        public IDbSet<SalesSalesOrderHeader> SalesSalesOrderHeader { get; set; } // SalesOrderHeader
        public IDbSet<SalesSalesOrderHeaderSalesReason> SalesSalesOrderHeaderSalesReason { get; set; } // SalesOrderHeaderSalesReason
        public IDbSet<SalesSalesPerson> SalesSalesPerson { get; set; } // SalesPerson
        public IDbSet<SalesSalesPersonQuotaHistory> SalesSalesPersonQuotaHistory { get; set; } // SalesPersonQuotaHistory
        public IDbSet<SalesSalesReason> SalesSalesReason { get; set; } // SalesReason
        public IDbSet<SalesSalesTaxRate> SalesSalesTaxRate { get; set; } // SalesTaxRate
        public IDbSet<SalesSalesTerritory> SalesSalesTerritory { get; set; } // SalesTerritory
        public IDbSet<SalesSalesTerritoryHistory> SalesSalesTerritoryHistory { get; set; } // SalesTerritoryHistory
        public IDbSet<SalesShoppingCartItem> SalesShoppingCartItem { get; set; } // ShoppingCartItem
        public IDbSet<SalesSpecialOffer> SalesSpecialOffer { get; set; } // SpecialOffer
        public IDbSet<SalesSpecialOfferProduct> SalesSpecialOfferProduct { get; set; } // SpecialOfferProduct
        public IDbSet<SalesStore> SalesStore { get; set; } // Store

        static AdventureWorksContext()
        {
            Database.SetInitializer<AdventureWorksContext>(null);
        }

        public AdventureWorksContext()
            : base("Name=AdventureWorks")
        {
        }

        public AdventureWorksContext(string connectionString) : base(connectionString)
        {
        }

        public AdventureWorksContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model) : base(connectionString, model)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new HumanResourcesDepartmentConfiguration());
            modelBuilder.Configurations.Add(new HumanResourcesEmployeeConfiguration());
            modelBuilder.Configurations.Add(new HumanResourcesEmployeeDepartmentHistoryConfiguration());
            modelBuilder.Configurations.Add(new HumanResourcesEmployeePayHistoryConfiguration());
            modelBuilder.Configurations.Add(new HumanResourcesJobCandidateConfiguration());
            modelBuilder.Configurations.Add(new HumanResourcesShiftConfiguration());
            modelBuilder.Configurations.Add(new PersonAddressConfiguration());
            modelBuilder.Configurations.Add(new PersonAddressTypeConfiguration());
            modelBuilder.Configurations.Add(new PersonBusinessEntityConfiguration());
            modelBuilder.Configurations.Add(new PersonBusinessEntityAddressConfiguration());
            modelBuilder.Configurations.Add(new PersonBusinessEntityContactConfiguration());
            modelBuilder.Configurations.Add(new PersonContactTypeConfiguration());
            modelBuilder.Configurations.Add(new PersonCountryRegionConfiguration());
            modelBuilder.Configurations.Add(new PersonEmailAddressConfiguration());
            modelBuilder.Configurations.Add(new PersonPasswordConfiguration());
            modelBuilder.Configurations.Add(new PersonPersonConfiguration());
            modelBuilder.Configurations.Add(new PersonPersonPhoneConfiguration());
            modelBuilder.Configurations.Add(new PersonPhoneNumberTypeConfiguration());
            modelBuilder.Configurations.Add(new PersonStateProvinceConfiguration());
            modelBuilder.Configurations.Add(new ProductionBillOfMaterialsConfiguration());
            modelBuilder.Configurations.Add(new ProductionCultureConfiguration());
            modelBuilder.Configurations.Add(new ProductionDocumentConfiguration());
            modelBuilder.Configurations.Add(new ProductionIllustrationConfiguration());
            modelBuilder.Configurations.Add(new ProductionLocationConfiguration());
            modelBuilder.Configurations.Add(new ProductionProductConfiguration());
            modelBuilder.Configurations.Add(new ProductionProductCategoryConfiguration());
            modelBuilder.Configurations.Add(new ProductionProductCostHistoryConfiguration());
            modelBuilder.Configurations.Add(new ProductionProductDescriptionConfiguration());
            modelBuilder.Configurations.Add(new ProductionProductDocumentConfiguration());
            modelBuilder.Configurations.Add(new ProductionProductInventoryConfiguration());
            modelBuilder.Configurations.Add(new ProductionProductListPriceHistoryConfiguration());
            modelBuilder.Configurations.Add(new ProductionProductModelConfiguration());
            modelBuilder.Configurations.Add(new ProductionProductModelIllustrationConfiguration());
            modelBuilder.Configurations.Add(new ProductionProductModelProductDescriptionCultureConfiguration());
            modelBuilder.Configurations.Add(new ProductionProductPhotoConfiguration());
            modelBuilder.Configurations.Add(new ProductionProductProductPhotoConfiguration());
            modelBuilder.Configurations.Add(new ProductionProductReviewConfiguration());
            modelBuilder.Configurations.Add(new ProductionProductSubcategoryConfiguration());
            modelBuilder.Configurations.Add(new ProductionScrapReasonConfiguration());
            modelBuilder.Configurations.Add(new ProductionTransactionHistoryConfiguration());
            modelBuilder.Configurations.Add(new ProductionTransactionHistoryArchiveConfiguration());
            modelBuilder.Configurations.Add(new ProductionUnitMeasureConfiguration());
            modelBuilder.Configurations.Add(new ProductionWorkOrderConfiguration());
            modelBuilder.Configurations.Add(new ProductionWorkOrderRoutingConfiguration());
            modelBuilder.Configurations.Add(new PurchasingProductVendorConfiguration());
            modelBuilder.Configurations.Add(new PurchasingPurchaseOrderDetailConfiguration());
            modelBuilder.Configurations.Add(new PurchasingPurchaseOrderHeaderConfiguration());
            modelBuilder.Configurations.Add(new PurchasingShipMethodConfiguration());
            modelBuilder.Configurations.Add(new PurchasingVendorConfiguration());
            modelBuilder.Configurations.Add(new SalesCountryRegionCurrencyConfiguration());
            modelBuilder.Configurations.Add(new SalesCreditCardConfiguration());
            modelBuilder.Configurations.Add(new SalesCurrencyConfiguration());
            modelBuilder.Configurations.Add(new SalesCurrencyRateConfiguration());
            modelBuilder.Configurations.Add(new SalesCustomerConfiguration());
            modelBuilder.Configurations.Add(new SalesPersonCreditCardConfiguration());
            modelBuilder.Configurations.Add(new SalesSalesOrderDetailConfiguration());
            modelBuilder.Configurations.Add(new SalesSalesOrderHeaderConfiguration());
            modelBuilder.Configurations.Add(new SalesSalesOrderHeaderSalesReasonConfiguration());
            modelBuilder.Configurations.Add(new SalesSalesPersonConfiguration());
            modelBuilder.Configurations.Add(new SalesSalesPersonQuotaHistoryConfiguration());
            modelBuilder.Configurations.Add(new SalesSalesReasonConfiguration());
            modelBuilder.Configurations.Add(new SalesSalesTaxRateConfiguration());
            modelBuilder.Configurations.Add(new SalesSalesTerritoryConfiguration());
            modelBuilder.Configurations.Add(new SalesSalesTerritoryHistoryConfiguration());
            modelBuilder.Configurations.Add(new SalesShoppingCartItemConfiguration());
            modelBuilder.Configurations.Add(new SalesSpecialOfferConfiguration());
            modelBuilder.Configurations.Add(new SalesSpecialOfferProductConfiguration());
            modelBuilder.Configurations.Add(new SalesStoreConfiguration());
        }

        public static DbModelBuilder CreateModel(DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new HumanResourcesDepartmentConfiguration(schema));
            modelBuilder.Configurations.Add(new HumanResourcesEmployeeConfiguration(schema));
            modelBuilder.Configurations.Add(new HumanResourcesEmployeeDepartmentHistoryConfiguration(schema));
            modelBuilder.Configurations.Add(new HumanResourcesEmployeePayHistoryConfiguration(schema));
            modelBuilder.Configurations.Add(new HumanResourcesJobCandidateConfiguration(schema));
            modelBuilder.Configurations.Add(new HumanResourcesShiftConfiguration(schema));
            modelBuilder.Configurations.Add(new PersonAddressConfiguration(schema));
            modelBuilder.Configurations.Add(new PersonAddressTypeConfiguration(schema));
            modelBuilder.Configurations.Add(new PersonBusinessEntityConfiguration(schema));
            modelBuilder.Configurations.Add(new PersonBusinessEntityAddressConfiguration(schema));
            modelBuilder.Configurations.Add(new PersonBusinessEntityContactConfiguration(schema));
            modelBuilder.Configurations.Add(new PersonContactTypeConfiguration(schema));
            modelBuilder.Configurations.Add(new PersonCountryRegionConfiguration(schema));
            modelBuilder.Configurations.Add(new PersonEmailAddressConfiguration(schema));
            modelBuilder.Configurations.Add(new PersonPasswordConfiguration(schema));
            modelBuilder.Configurations.Add(new PersonPersonConfiguration(schema));
            modelBuilder.Configurations.Add(new PersonPersonPhoneConfiguration(schema));
            modelBuilder.Configurations.Add(new PersonPhoneNumberTypeConfiguration(schema));
            modelBuilder.Configurations.Add(new PersonStateProvinceConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductionBillOfMaterialsConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductionCultureConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductionDocumentConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductionIllustrationConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductionLocationConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductionProductConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductionProductCategoryConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductionProductCostHistoryConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductionProductDescriptionConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductionProductDocumentConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductionProductInventoryConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductionProductListPriceHistoryConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductionProductModelConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductionProductModelIllustrationConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductionProductModelProductDescriptionCultureConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductionProductPhotoConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductionProductProductPhotoConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductionProductReviewConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductionProductSubcategoryConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductionScrapReasonConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductionTransactionHistoryConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductionTransactionHistoryArchiveConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductionUnitMeasureConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductionWorkOrderConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductionWorkOrderRoutingConfiguration(schema));
            modelBuilder.Configurations.Add(new PurchasingProductVendorConfiguration(schema));
            modelBuilder.Configurations.Add(new PurchasingPurchaseOrderDetailConfiguration(schema));
            modelBuilder.Configurations.Add(new PurchasingPurchaseOrderHeaderConfiguration(schema));
            modelBuilder.Configurations.Add(new PurchasingShipMethodConfiguration(schema));
            modelBuilder.Configurations.Add(new PurchasingVendorConfiguration(schema));
            modelBuilder.Configurations.Add(new SalesCountryRegionCurrencyConfiguration(schema));
            modelBuilder.Configurations.Add(new SalesCreditCardConfiguration(schema));
            modelBuilder.Configurations.Add(new SalesCurrencyConfiguration(schema));
            modelBuilder.Configurations.Add(new SalesCurrencyRateConfiguration(schema));
            modelBuilder.Configurations.Add(new SalesCustomerConfiguration(schema));
            modelBuilder.Configurations.Add(new SalesPersonCreditCardConfiguration(schema));
            modelBuilder.Configurations.Add(new SalesSalesOrderDetailConfiguration(schema));
            modelBuilder.Configurations.Add(new SalesSalesOrderHeaderConfiguration(schema));
            modelBuilder.Configurations.Add(new SalesSalesOrderHeaderSalesReasonConfiguration(schema));
            modelBuilder.Configurations.Add(new SalesSalesPersonConfiguration(schema));
            modelBuilder.Configurations.Add(new SalesSalesPersonQuotaHistoryConfiguration(schema));
            modelBuilder.Configurations.Add(new SalesSalesReasonConfiguration(schema));
            modelBuilder.Configurations.Add(new SalesSalesTaxRateConfiguration(schema));
            modelBuilder.Configurations.Add(new SalesSalesTerritoryConfiguration(schema));
            modelBuilder.Configurations.Add(new SalesSalesTerritoryHistoryConfiguration(schema));
            modelBuilder.Configurations.Add(new SalesShoppingCartItemConfiguration(schema));
            modelBuilder.Configurations.Add(new SalesSpecialOfferConfiguration(schema));
            modelBuilder.Configurations.Add(new SalesSpecialOfferProductConfiguration(schema));
            modelBuilder.Configurations.Add(new SalesStoreConfiguration(schema));
            return modelBuilder;
        }
    }

    // ************************************************************************
    // POCO classes

    // Department
    public class HumanResourcesDepartment
    {
        public short DepartmentId { get; set; } // DepartmentID (Primary key). Primary key for Department records.
        public string Name { get; set; } // Name. Name of the department.
        public string GroupName { get; set; } // GroupName. Name of the group to which the department belongs.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<HumanResourcesEmployeeDepartmentHistory> HumanResourcesEmployeeDepartmentHistory { get; set; } // Many to many mapping

        public HumanResourcesDepartment()
        {
            ModifiedDate = System.DateTime.Now;
            HumanResourcesEmployeeDepartmentHistory = new List<HumanResourcesEmployeeDepartmentHistory>();
        }
    }

    // Employee
    public class HumanResourcesEmployee
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Primary key for Employee records.  Foreign key to BusinessEntity.BusinessEntityID.
        public string NationalIdNumber { get; set; } // NationalIDNumber. Unique national identification number such as a social security number.
        public string LoginId { get; set; } // LoginID. Network login.
        public HierarchyId OrganizationNode { get; set; } // OrganizationNode. Where the employee is located in corporate hierarchy.
        public short? OrganizationLevel { get; internal set; } // OrganizationLevel. The depth of the employee in the corporate hierarchy.
        public string JobTitle { get; set; } // JobTitle. Work title such as Buyer or Sales Representative.
        public DateTime BirthDate { get; set; } // BirthDate. Date of birth.
        public string MaritalStatus { get; set; } // MaritalStatus. M = Married, S = Single
        public string Gender { get; set; } // Gender. M = Male, F = Female
        public DateTime HireDate { get; set; } // HireDate. Employee hired on this date.
        public bool SalariedFlag { get; set; } // SalariedFlag. Job classification. 0 = Hourly, not exempt from collective bargaining. 1 = Salaried, exempt from collective bargaining.
        public short VacationHours { get; set; } // VacationHours. Number of available vacation hours.
        public short SickLeaveHours { get; set; } // SickLeaveHours. Number of available sick leave hours.
        public bool CurrentFlag { get; set; } // CurrentFlag. 0 = Inactive, 1 = Active
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<HumanResourcesEmployeeDepartmentHistory> HumanResourcesEmployeeDepartmentHistory { get; set; } // Many to many mapping
        public virtual ICollection<HumanResourcesEmployeePayHistory> HumanResourcesEmployeePayHistory { get; set; } // Many to many mapping
        public virtual ICollection<HumanResourcesJobCandidate> HumanResourcesJobCandidate { get; set; } // JobCandidate.FK_JobCandidate_Employee_BusinessEntityID
        public virtual ICollection<ProductionDocument> ProductionDocument { get; set; } // Document.FK_Document_Employee_Owner
        public virtual ICollection<PurchasingPurchaseOrderHeader> PurchasingPurchaseOrderHeader { get; set; } // PurchaseOrderHeader.FK_PurchaseOrderHeader_Employee_EmployeeID
        public virtual SalesSalesPerson SalesSalesPerson { get; set; } // SalesPerson.FK_SalesPerson_Employee_BusinessEntityID

        // Foreign keys
        public virtual PersonPerson PersonPerson { get; set; } // FK_Employee_Person_BusinessEntityID

        public HumanResourcesEmployee()
        {
            SalariedFlag = true;
            VacationHours = 0;
            SickLeaveHours = 0;
            CurrentFlag = true;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            ProductionDocument = new List<ProductionDocument>();
            HumanResourcesEmployeeDepartmentHistory = new List<HumanResourcesEmployeeDepartmentHistory>();
            HumanResourcesEmployeePayHistory = new List<HumanResourcesEmployeePayHistory>();
            HumanResourcesJobCandidate = new List<HumanResourcesJobCandidate>();
            PurchasingPurchaseOrderHeader = new List<PurchasingPurchaseOrderHeader>();
        }
    }

    // EmployeeDepartmentHistory
    public class HumanResourcesEmployeeDepartmentHistory
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Employee identification number. Foreign key to Employee.BusinessEntityID.
        public short DepartmentId { get; set; } // DepartmentID (Primary key). Department in which the employee worked including currently. Foreign key to Department.DepartmentID.
        public byte ShiftId { get; set; } // ShiftID (Primary key). Identifies which 8-hour shift the employee works. Foreign key to Shift.Shift.ID.
        public DateTime StartDate { get; set; } // StartDate (Primary key). Date the employee started work in the department.
        public DateTime? EndDate { get; set; } // EndDate. Date the employee left the department. NULL = Current department.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual HumanResourcesDepartment HumanResourcesDepartment { get; set; } // FK_EmployeeDepartmentHistory_Department_DepartmentID
        public virtual HumanResourcesEmployee HumanResourcesEmployee { get; set; } // FK_EmployeeDepartmentHistory_Employee_BusinessEntityID
        public virtual HumanResourcesShift HumanResourcesShift { get; set; } // FK_EmployeeDepartmentHistory_Shift_ShiftID

        public HumanResourcesEmployeeDepartmentHistory()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

    // EmployeePayHistory
    public class HumanResourcesEmployeePayHistory
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Employee identification number. Foreign key to Employee.BusinessEntityID.
        public DateTime RateChangeDate { get; set; } // RateChangeDate (Primary key). Date the change in pay is effective
        public decimal Rate { get; set; } // Rate. Salary hourly rate.
        public byte PayFrequency { get; set; } // PayFrequency. 1 = Salary received monthly, 2 = Salary received biweekly
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual HumanResourcesEmployee HumanResourcesEmployee { get; set; } // FK_EmployeePayHistory_Employee_BusinessEntityID

        public HumanResourcesEmployeePayHistory()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

    // JobCandidate
    public class HumanResourcesJobCandidate
    {
        public int JobCandidateId { get; set; } // JobCandidateID (Primary key). Primary key for JobCandidate records.
        public int? BusinessEntityId { get; set; } // BusinessEntityID. Employee identification number if applicant was hired. Foreign key to Employee.BusinessEntityID.
        public string Resume { get; set; } // Resume. Résumé in XML format.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual HumanResourcesEmployee HumanResourcesEmployee { get; set; } // FK_JobCandidate_Employee_BusinessEntityID

        public HumanResourcesJobCandidate()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

    // Shift
    public class HumanResourcesShift
    {
        public byte ShiftId { get; set; } // ShiftID (Primary key). Primary key for Shift records.
        public string Name { get; set; } // Name. Shift description.
        public TimeSpan StartTime { get; set; } // StartTime. Shift start time.
        public TimeSpan EndTime { get; set; } // EndTime. Shift end time.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<HumanResourcesEmployeeDepartmentHistory> HumanResourcesEmployeeDepartmentHistory { get; set; } // Many to many mapping

        public HumanResourcesShift()
        {
            ModifiedDate = System.DateTime.Now;
            HumanResourcesEmployeeDepartmentHistory = new List<HumanResourcesEmployeeDepartmentHistory>();
        }
    }

    // Address
    public class PersonAddress
    {
        public int AddressId { get; set; } // AddressID (Primary key). Primary key for Address records.
        public string AddressLine1 { get; set; } // AddressLine1. First street address line.
        public string AddressLine2 { get; set; } // AddressLine2. Second street address line.
        public string City { get; set; } // City. Name of the city.
        public int StateProvinceId { get; set; } // StateProvinceID. Unique identification number for the state or province. Foreign key to StateProvince table.
        public string PostalCode { get; set; } // PostalCode. Postal code for the street address.
        public System.Data.Entity.Spatial.DbGeography SpatialLocation { get; set; } // SpatialLocation. Latitude and longitude of this address.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<PersonBusinessEntityAddress> PersonBusinessEntityAddress { get; set; } // Many to many mapping
        public virtual ICollection<SalesSalesOrderHeader> SalesSalesOrderHeader_BillToAddressId { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_Address_BillToAddressID
        public virtual ICollection<SalesSalesOrderHeader> SalesSalesOrderHeader_ShipToAddressId { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_Address_ShipToAddressID

        // Foreign keys
        public virtual PersonStateProvince PersonStateProvince { get; set; } // FK_Address_StateProvince_StateProvinceID

        public PersonAddress()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            PersonBusinessEntityAddress = new List<PersonBusinessEntityAddress>();
            SalesSalesOrderHeader_BillToAddressId = new List<SalesSalesOrderHeader>();
            SalesSalesOrderHeader_ShipToAddressId = new List<SalesSalesOrderHeader>();
        }
    }

    // AddressType
    public class PersonAddressType
    {
        public int AddressTypeId { get; set; } // AddressTypeID (Primary key). Primary key for AddressType records.
        public string Name { get; set; } // Name. Address type description. For example, Billing, Home, or Shipping.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<PersonBusinessEntityAddress> PersonBusinessEntityAddress { get; set; } // Many to many mapping

        public PersonAddressType()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            PersonBusinessEntityAddress = new List<PersonBusinessEntityAddress>();
        }
    }

    // BusinessEntity
    public class PersonBusinessEntity
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Primary key for all customers, vendors, and employees.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<PersonBusinessEntityAddress> PersonBusinessEntityAddress { get; set; } // Many to many mapping
        public virtual ICollection<PersonBusinessEntityContact> PersonBusinessEntityContact { get; set; } // Many to many mapping
        public virtual PersonPerson PersonPerson { get; set; } // Person.FK_Person_BusinessEntity_BusinessEntityID
        public virtual PurchasingVendor PurchasingVendor { get; set; } // Vendor.FK_Vendor_BusinessEntity_BusinessEntityID
        public virtual SalesStore SalesStore { get; set; } // Store.FK_Store_BusinessEntity_BusinessEntityID

        public PersonBusinessEntity()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            PersonBusinessEntityAddress = new List<PersonBusinessEntityAddress>();
            PersonBusinessEntityContact = new List<PersonBusinessEntityContact>();
        }
    }

    // BusinessEntityAddress
    public class PersonBusinessEntityAddress
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Primary key. Foreign key to BusinessEntity.BusinessEntityID.
        public int AddressId { get; set; } // AddressID (Primary key). Primary key. Foreign key to Address.AddressID.
        public int AddressTypeId { get; set; } // AddressTypeID (Primary key). Primary key. Foreign key to AddressType.AddressTypeID.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual PersonAddress PersonAddress { get; set; } // FK_BusinessEntityAddress_Address_AddressID
        public virtual PersonAddressType PersonAddressType { get; set; } // FK_BusinessEntityAddress_AddressType_AddressTypeID
        public virtual PersonBusinessEntity PersonBusinessEntity { get; set; } // FK_BusinessEntityAddress_BusinessEntity_BusinessEntityID

        public PersonBusinessEntityAddress()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
        }
    }

    // BusinessEntityContact
    public class PersonBusinessEntityContact
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Primary key. Foreign key to BusinessEntity.BusinessEntityID.
        public int PersonId { get; set; } // PersonID (Primary key). Primary key. Foreign key to Person.BusinessEntityID.
        public int ContactTypeId { get; set; } // ContactTypeID (Primary key). Primary key.  Foreign key to ContactType.ContactTypeID.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual PersonBusinessEntity PersonBusinessEntity { get; set; } // FK_BusinessEntityContact_BusinessEntity_BusinessEntityID
        public virtual PersonContactType PersonContactType { get; set; } // FK_BusinessEntityContact_ContactType_ContactTypeID
        public virtual PersonPerson PersonPerson { get; set; } // FK_BusinessEntityContact_Person_PersonID

        public PersonBusinessEntityContact()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
        }
    }

    // ContactType
    public class PersonContactType
    {
        public int ContactTypeId { get; set; } // ContactTypeID (Primary key). Primary key for ContactType records.
        public string Name { get; set; } // Name. Contact type description.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<PersonBusinessEntityContact> PersonBusinessEntityContact { get; set; } // Many to many mapping

        public PersonContactType()
        {
            ModifiedDate = System.DateTime.Now;
            PersonBusinessEntityContact = new List<PersonBusinessEntityContact>();
        }
    }

    // CountryRegion
    public class PersonCountryRegion
    {
        public string CountryRegionCode { get; set; } // CountryRegionCode (Primary key). ISO standard code for countries and regions.
        public string Name { get; set; } // Name. Country or region name.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<PersonStateProvince> PersonStateProvince { get; set; } // StateProvince.FK_StateProvince_CountryRegion_CountryRegionCode
        public virtual ICollection<SalesCountryRegionCurrency> SalesCountryRegionCurrency { get; set; } // Many to many mapping
        public virtual ICollection<SalesSalesTerritory> SalesSalesTerritory { get; set; } // SalesTerritory.FK_SalesTerritory_CountryRegion_CountryRegionCode

        public PersonCountryRegion()
        {
            ModifiedDate = System.DateTime.Now;
            SalesCountryRegionCurrency = new List<SalesCountryRegionCurrency>();
            SalesSalesTerritory = new List<SalesSalesTerritory>();
            PersonStateProvince = new List<PersonStateProvince>();
        }
    }

    // EmailAddress
    public class PersonEmailAddress
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Primary key. Person associated with this email address.  Foreign key to Person.BusinessEntityID
        public int EmailAddressId { get; set; } // EmailAddressID (Primary key). Primary key. ID of this email address.
        public string EmailAddress { get; set; } // EmailAddress. E-mail address for the person.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual PersonPerson PersonPerson { get; set; } // FK_EmailAddress_Person_BusinessEntityID

        public PersonEmailAddress()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
        }
    }

    // Password
    public class PersonPassword
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key)
        public string PasswordHash { get; set; } // PasswordHash. Password for the e-mail account.
        public string PasswordSalt { get; set; } // PasswordSalt. Random value concatenated with the password string before the password is hashed.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual PersonPerson PersonPerson { get; set; } // FK_Password_Person_BusinessEntityID

        public PersonPassword()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
        }
    }

    // Person
    public class PersonPerson
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Primary key for Person records.
        public string PersonType { get; set; } // PersonType. Primary type of person: SC = Store Contact, IN = Individual (retail) customer, SP = Sales person, EM = Employee (non-sales), VC = Vendor contact, GC = General contact
        public bool NameStyle { get; set; } // NameStyle. 0 = The data in FirstName and LastName are stored in western style (first name, last name) order.  1 = Eastern style (last name, first name) order.
        public string Title { get; set; } // Title. A courtesy title. For example, Mr. or Ms.
        public string FirstName { get; set; } // FirstName. First name of the person.
        public string MiddleName { get; set; } // MiddleName. Middle name or middle initial of the person.
        public string LastName { get; set; } // LastName. Last name of the person.
        public string Suffix { get; set; } // Suffix. Surname suffix. For example, Sr. or Jr.
        public int EmailPromotion { get; set; } // EmailPromotion. 0 = Contact does not wish to receive e-mail promotions, 1 = Contact does wish to receive e-mail promotions from AdventureWorks, 2 = Contact does wish to receive e-mail promotions from AdventureWorks and selected partners.
        public string AdditionalContactInfo { get; set; } // AdditionalContactInfo. Additional contact information about the person stored in xml format.
        public string Demographics { get; set; } // Demographics. Personal information such as hobbies, and income collected from online shoppers. Used for sales analysis.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual HumanResourcesEmployee HumanResourcesEmployee { get; set; } // Employee.FK_Employee_Person_BusinessEntityID
        public virtual ICollection<PersonBusinessEntityContact> PersonBusinessEntityContact { get; set; } // Many to many mapping
        public virtual ICollection<PersonEmailAddress> PersonEmailAddress { get; set; } // Many to many mapping
        public virtual ICollection<PersonPersonPhone> PersonPersonPhone { get; set; } // Many to many mapping
        public virtual ICollection<SalesCustomer> SalesCustomer { get; set; } // Customer.FK_Customer_Person_PersonID
        public virtual ICollection<SalesPersonCreditCard> SalesPersonCreditCard { get; set; } // Many to many mapping
        public virtual PersonPassword PersonPassword { get; set; } // Password.FK_Password_Person_BusinessEntityID

        // Foreign keys
        public virtual PersonBusinessEntity PersonBusinessEntity { get; set; } // FK_Person_BusinessEntity_BusinessEntityID

        public PersonPerson()
        {
            NameStyle = false;
            EmailPromotion = 0;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            PersonBusinessEntityContact = new List<PersonBusinessEntityContact>();
            SalesCustomer = new List<SalesCustomer>();
            PersonEmailAddress = new List<PersonEmailAddress>();
            SalesPersonCreditCard = new List<SalesPersonCreditCard>();
            PersonPersonPhone = new List<PersonPersonPhone>();
        }
    }

    // PersonPhone
    public class PersonPersonPhone
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Business entity identification number. Foreign key to Person.BusinessEntityID.
        public string PhoneNumber { get; set; } // PhoneNumber (Primary key). Telephone number identification number.
        public int PhoneNumberTypeId { get; set; } // PhoneNumberTypeID (Primary key). Kind of phone number. Foreign key to PhoneNumberType.PhoneNumberTypeID.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual PersonPerson PersonPerson { get; set; } // FK_PersonPhone_Person_BusinessEntityID
        public virtual PersonPhoneNumberType PersonPhoneNumberType { get; set; } // FK_PersonPhone_PhoneNumberType_PhoneNumberTypeID

        public PersonPersonPhone()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

    // PhoneNumberType
    public class PersonPhoneNumberType
    {
        public int PhoneNumberTypeId { get; set; } // PhoneNumberTypeID (Primary key). Primary key for telephone number type records.
        public string Name { get; set; } // Name. Name of the telephone number type
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<PersonPersonPhone> PersonPersonPhone { get; set; } // Many to many mapping

        public PersonPhoneNumberType()
        {
            ModifiedDate = System.DateTime.Now;
            PersonPersonPhone = new List<PersonPersonPhone>();
        }
    }

    // StateProvince
    public class PersonStateProvince
    {
        public int StateProvinceId { get; set; } // StateProvinceID (Primary key). Primary key for StateProvince records.
        public string StateProvinceCode { get; set; } // StateProvinceCode. ISO standard state or province code.
        public string CountryRegionCode { get; set; } // CountryRegionCode. ISO standard country or region code. Foreign key to CountryRegion.CountryRegionCode.
        public bool IsOnlyStateProvinceFlag { get; set; } // IsOnlyStateProvinceFlag. 0 = StateProvinceCode exists. 1 = StateProvinceCode unavailable, using CountryRegionCode.
        public string Name { get; set; } // Name. State or province description.
        public int TerritoryId { get; set; } // TerritoryID. ID of the territory in which the state or province is located. Foreign key to SalesTerritory.SalesTerritoryID.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<PersonAddress> PersonAddress { get; set; } // Address.FK_Address_StateProvince_StateProvinceID
        public virtual ICollection<SalesSalesTaxRate> SalesSalesTaxRate { get; set; } // SalesTaxRate.FK_SalesTaxRate_StateProvince_StateProvinceID

        // Foreign keys
        public virtual PersonCountryRegion PersonCountryRegion { get; set; } // FK_StateProvince_CountryRegion_CountryRegionCode
        public virtual SalesSalesTerritory SalesSalesTerritory { get; set; } // FK_StateProvince_SalesTerritory_TerritoryID

        public PersonStateProvince()
        {
            IsOnlyStateProvinceFlag = true;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            PersonAddress = new List<PersonAddress>();
            SalesSalesTaxRate = new List<SalesSalesTaxRate>();
        }
    }

    // BillOfMaterials
    public class ProductionBillOfMaterials
    {
        public int BillOfMaterialsId { get; set; } // BillOfMaterialsID (Primary key). Primary key for BillOfMaterials records.
        public int? ProductAssemblyId { get; set; } // ProductAssemblyID. Parent product identification number. Foreign key to Product.ProductID.
        public int ComponentId { get; set; } // ComponentID. Component identification number. Foreign key to Product.ProductID.
        public DateTime StartDate { get; set; } // StartDate. Date the component started being used in the assembly item.
        public DateTime? EndDate { get; set; } // EndDate. Date the component stopped being used in the assembly item.
        public string UnitMeasureCode { get; set; } // UnitMeasureCode. Standard code identifying the unit of measure for the quantity.
        public short BomLevel { get; set; } // BOMLevel. Indicates the depth the component is from its parent (AssemblyID).
        public decimal PerAssemblyQty { get; set; } // PerAssemblyQty. Quantity of the component needed to create the assembly.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual ProductionProduct ProductionProduct_ComponentId { get; set; } // FK_BillOfMaterials_Product_ComponentID
        public virtual ProductionProduct ProductionProduct_ProductAssemblyId { get; set; } // FK_BillOfMaterials_Product_ProductAssemblyID
        public virtual ProductionUnitMeasure ProductionUnitMeasure { get; set; } // FK_BillOfMaterials_UnitMeasure_UnitMeasureCode

        public ProductionBillOfMaterials()
        {
            StartDate = System.DateTime.Now;
            PerAssemblyQty = 1.00m;
            ModifiedDate = System.DateTime.Now;
        }
    }

    // Culture
    public class ProductionCulture
    {
        public string CultureId { get; set; } // CultureID (Primary key). Primary key for Culture records.
        public string Name { get; set; } // Name. Culture description.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<ProductionProductModelProductDescriptionCulture> ProductionProductModelProductDescriptionCulture { get; set; } // Many to many mapping

        public ProductionCulture()
        {
            ModifiedDate = System.DateTime.Now;
            ProductionProductModelProductDescriptionCulture = new List<ProductionProductModelProductDescriptionCulture>();
        }
    }

    // Document
    public class ProductionDocument
    {
        public HierarchyId DocumentNode { get; set; } // DocumentNode (Primary key). Primary key for Document records.
        public short? DocumentLevel { get; internal set; } // DocumentLevel. Depth in the document hierarchy.
        public string Title { get; set; } // Title. Title of the document.
        public int Owner { get; set; } // Owner. Employee who controls the document.  Foreign key to Employee.BusinessEntityID
        public bool FolderFlag { get; set; } // FolderFlag. 0 = This is a folder, 1 = This is a document.
        public string FileName { get; set; } // FileName. File name of the document
        public string FileExtension { get; set; } // FileExtension. File extension indicating the document type. For example, .doc or .txt.
        public string Revision { get; set; } // Revision. Revision number of the document.
        public int ChangeNumber { get; set; } // ChangeNumber. Engineering change approval number.
        public byte Status { get; set; } // Status. 1 = Pending approval, 2 = Approved, 3 = Obsolete
        public string DocumentSummary { get; set; } // DocumentSummary. Document abstract.
        public byte[] Document { get; set; } // Document. Complete document.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Required for FileStream.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<ProductionProductDocument> ProductionProductDocument { get; set; } // Many to many mapping

        // Foreign keys
        public virtual HumanResourcesEmployee HumanResourcesEmployee { get; set; } // FK_Document_Employee_Owner

        public ProductionDocument()
        {
            FolderFlag = false;
            ChangeNumber = 0;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            ProductionProductDocument = new List<ProductionProductDocument>();
        }
    }

    // Illustration
    public class ProductionIllustration
    {
        public int IllustrationId { get; set; } // IllustrationID (Primary key). Primary key for Illustration records.
        public string Diagram { get; set; } // Diagram. Illustrations used in manufacturing instructions. Stored as XML.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<ProductionProductModelIllustration> ProductionProductModelIllustration { get; set; } // Many to many mapping

        public ProductionIllustration()
        {
            ModifiedDate = System.DateTime.Now;
            ProductionProductModelIllustration = new List<ProductionProductModelIllustration>();
        }
    }

    // Location
    public class ProductionLocation
    {
        public short LocationId { get; set; } // LocationID (Primary key). Primary key for Location records.
        public string Name { get; set; } // Name. Location description.
        public decimal CostRate { get; set; } // CostRate. Standard hourly cost of the manufacturing location.
        public decimal Availability { get; set; } // Availability. Work capacity (in hours) of the manufacturing location.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<ProductionProductInventory> ProductionProductInventory { get; set; } // Many to many mapping
        public virtual ICollection<ProductionWorkOrderRouting> ProductionWorkOrderRouting { get; set; } // WorkOrderRouting.FK_WorkOrderRouting_Location_LocationID

        public ProductionLocation()
        {
            CostRate = 0.00m;
            Availability = 0.00m;
            ModifiedDate = System.DateTime.Now;
            ProductionProductInventory = new List<ProductionProductInventory>();
            ProductionWorkOrderRouting = new List<ProductionWorkOrderRouting>();
        }
    }

    // Product
    public class ProductionProduct
    {
        public int ProductId { get; set; } // ProductID (Primary key). Primary key for Product records.
        public string Name { get; set; } // Name. Name of the product.
        public string ProductNumber { get; set; } // ProductNumber. Unique product identification number.
        public bool MakeFlag { get; set; } // MakeFlag. 0 = Product is purchased, 1 = Product is manufactured in-house.
        public bool FinishedGoodsFlag { get; set; } // FinishedGoodsFlag. 0 = Product is not a salable item. 1 = Product is salable.
        public string Color { get; set; } // Color. Product color.
        public short SafetyStockLevel { get; set; } // SafetyStockLevel. Minimum inventory quantity.
        public short ReorderPoint { get; set; } // ReorderPoint. Inventory level that triggers a purchase order or work order.
        public decimal StandardCost { get; set; } // StandardCost. Standard cost of the product.
        public decimal ListPrice { get; set; } // ListPrice. Selling price.
        public string Size { get; set; } // Size. Product size.
        public string SizeUnitMeasureCode { get; set; } // SizeUnitMeasureCode. Unit of measure for Size column.
        public string WeightUnitMeasureCode { get; set; } // WeightUnitMeasureCode. Unit of measure for Weight column.
        public decimal? Weight { get; set; } // Weight. Product weight.
        public int DaysToManufacture { get; set; } // DaysToManufacture. Number of days required to manufacture the product.
        public string ProductLine { get; set; } // ProductLine. R = Road, M = Mountain, T = Touring, S = Standard
        public string Class { get; set; } // Class. H = High, M = Medium, L = Low
        public string Style { get; set; } // Style. W = Womens, M = Mens, U = Universal
        public int? ProductSubcategoryId { get; set; } // ProductSubcategoryID. Product is a member of this product subcategory. Foreign key to ProductSubCategory.ProductSubCategoryID.
        public int? ProductModelId { get; set; } // ProductModelID. Product is a member of this product model. Foreign key to ProductModel.ProductModelID.
        public DateTime SellStartDate { get; set; } // SellStartDate. Date the product was available for sale.
        public DateTime? SellEndDate { get; set; } // SellEndDate. Date the product was no longer available for sale.
        public DateTime? DiscontinuedDate { get; set; } // DiscontinuedDate. Date the product was discontinued.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<ProductionBillOfMaterials> ProductionBillOfMaterials_ComponentId { get; set; } // BillOfMaterials.FK_BillOfMaterials_Product_ComponentID
        public virtual ICollection<ProductionBillOfMaterials> ProductionBillOfMaterials_ProductAssemblyId { get; set; } // BillOfMaterials.FK_BillOfMaterials_Product_ProductAssemblyID
        public virtual ICollection<ProductionProductCostHistory> ProductionProductCostHistory { get; set; } // Many to many mapping
        public virtual ICollection<ProductionProductDocument> ProductionProductDocument { get; set; } // Many to many mapping
        public virtual ICollection<ProductionProductInventory> ProductionProductInventory { get; set; } // Many to many mapping
        public virtual ICollection<ProductionProductListPriceHistory> ProductionProductListPriceHistory { get; set; } // Many to many mapping
        public virtual ICollection<ProductionProductProductPhoto> ProductionProductProductPhoto { get; set; } // Many to many mapping
        public virtual ICollection<ProductionProductReview> ProductionProductReview { get; set; } // ProductReview.FK_ProductReview_Product_ProductID
        public virtual ICollection<ProductionTransactionHistory> ProductionTransactionHistory { get; set; } // TransactionHistory.FK_TransactionHistory_Product_ProductID
        public virtual ICollection<ProductionWorkOrder> ProductionWorkOrder { get; set; } // WorkOrder.FK_WorkOrder_Product_ProductID
        public virtual ICollection<PurchasingProductVendor> PurchasingProductVendor { get; set; } // Many to many mapping
        public virtual ICollection<PurchasingPurchaseOrderDetail> PurchasingPurchaseOrderDetail { get; set; } // PurchaseOrderDetail.FK_PurchaseOrderDetail_Product_ProductID
        public virtual ICollection<SalesShoppingCartItem> SalesShoppingCartItem { get; set; } // ShoppingCartItem.FK_ShoppingCartItem_Product_ProductID
        public virtual ICollection<SalesSpecialOfferProduct> SalesSpecialOfferProduct { get; set; } // Many to many mapping

        // Foreign keys
        public virtual ProductionProductModel ProductionProductModel { get; set; } // FK_Product_ProductModel_ProductModelID
        public virtual ProductionProductSubcategory ProductionProductSubcategory { get; set; } // FK_Product_ProductSubcategory_ProductSubcategoryID
        public virtual ProductionUnitMeasure ProductionUnitMeasure_SizeUnitMeasureCode { get; set; } // FK_Product_UnitMeasure_SizeUnitMeasureCode
        public virtual ProductionUnitMeasure ProductionUnitMeasure_WeightUnitMeasureCode { get; set; } // FK_Product_UnitMeasure_WeightUnitMeasureCode

        public ProductionProduct()
        {
            MakeFlag = true;
            FinishedGoodsFlag = true;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            ProductionBillOfMaterials_ComponentId = new List<ProductionBillOfMaterials>();
            ProductionBillOfMaterials_ProductAssemblyId = new List<ProductionBillOfMaterials>();
            ProductionProductCostHistory = new List<ProductionProductCostHistory>();
            ProductionProductDocument = new List<ProductionProductDocument>();
            ProductionProductInventory = new List<ProductionProductInventory>();
            ProductionProductListPriceHistory = new List<ProductionProductListPriceHistory>();
            ProductionProductProductPhoto = new List<ProductionProductProductPhoto>();
            ProductionProductReview = new List<ProductionProductReview>();
            PurchasingProductVendor = new List<PurchasingProductVendor>();
            PurchasingPurchaseOrderDetail = new List<PurchasingPurchaseOrderDetail>();
            SalesShoppingCartItem = new List<SalesShoppingCartItem>();
            SalesSpecialOfferProduct = new List<SalesSpecialOfferProduct>();
            ProductionTransactionHistory = new List<ProductionTransactionHistory>();
            ProductionWorkOrder = new List<ProductionWorkOrder>();
        }
    }

    // ProductCategory
    public class ProductionProductCategory
    {
        public int ProductCategoryId { get; set; } // ProductCategoryID (Primary key). Primary key for ProductCategory records.
        public string Name { get; set; } // Name. Category description.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<ProductionProductSubcategory> ProductionProductSubcategory { get; set; } // ProductSubcategory.FK_ProductSubcategory_ProductCategory_ProductCategoryID

        public ProductionProductCategory()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            ProductionProductSubcategory = new List<ProductionProductSubcategory>();
        }
    }

    // ProductCostHistory
    public class ProductionProductCostHistory
    {
        public int ProductId { get; set; } // ProductID (Primary key). Product identification number. Foreign key to Product.ProductID
        public DateTime StartDate { get; set; } // StartDate (Primary key). Product cost start date.
        public DateTime? EndDate { get; set; } // EndDate. Product cost end date.
        public decimal StandardCost { get; set; } // StandardCost. Standard cost of the product.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual ProductionProduct ProductionProduct { get; set; } // FK_ProductCostHistory_Product_ProductID

        public ProductionProductCostHistory()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

    // ProductDescription
    public class ProductionProductDescription
    {
        public int ProductDescriptionId { get; set; } // ProductDescriptionID (Primary key). Primary key for ProductDescription records.
        public string Description { get; set; } // Description. Description of the product.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<ProductionProductModelProductDescriptionCulture> ProductionProductModelProductDescriptionCulture { get; set; } // Many to many mapping

        public ProductionProductDescription()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            ProductionProductModelProductDescriptionCulture = new List<ProductionProductModelProductDescriptionCulture>();
        }
    }

    // ProductDocument
    public class ProductionProductDocument
    {
        public int ProductId { get; set; } // ProductID (Primary key). Product identification number. Foreign key to Product.ProductID.
        public HierarchyId DocumentNode { get; set; } // DocumentNode (Primary key). Document identification number. Foreign key to Document.DocumentNode.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual ProductionDocument ProductionDocument { get; set; } // FK_ProductDocument_Document_DocumentNode
        public virtual ProductionProduct ProductionProduct { get; set; } // FK_ProductDocument_Product_ProductID

        public ProductionProductDocument()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

    // ProductInventory
    public class ProductionProductInventory
    {
        public int ProductId { get; set; } // ProductID (Primary key). Product identification number. Foreign key to Product.ProductID.
        public short LocationId { get; set; } // LocationID (Primary key). Inventory location identification number. Foreign key to Location.LocationID.
        public string Shelf { get; set; } // Shelf. Storage compartment within an inventory location.
        public byte Bin { get; set; } // Bin. Storage container on a shelf in an inventory location.
        public short Quantity { get; set; } // Quantity. Quantity of products in the inventory location.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual ProductionLocation ProductionLocation { get; set; } // FK_ProductInventory_Location_LocationID
        public virtual ProductionProduct ProductionProduct { get; set; } // FK_ProductInventory_Product_ProductID

        public ProductionProductInventory()
        {
            Quantity = 0;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
        }
    }

    // ProductListPriceHistory
    public class ProductionProductListPriceHistory
    {
        public int ProductId { get; set; } // ProductID (Primary key). Product identification number. Foreign key to Product.ProductID
        public DateTime StartDate { get; set; } // StartDate (Primary key). List price start date.
        public DateTime? EndDate { get; set; } // EndDate. List price end date
        public decimal ListPrice { get; set; } // ListPrice. Product list price.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual ProductionProduct ProductionProduct { get; set; } // FK_ProductListPriceHistory_Product_ProductID

        public ProductionProductListPriceHistory()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

    // ProductModel
    public class ProductionProductModel
    {
        public int ProductModelId { get; set; } // ProductModelID (Primary key). Primary key for ProductModel records.
        public string Name { get; set; } // Name. Product model description.
        public string CatalogDescription { get; set; } // CatalogDescription. Detailed product catalog information in xml format.
        public string Instructions { get; set; } // Instructions. Manufacturing instructions in xml format.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<ProductionProduct> ProductionProduct { get; set; } // Product.FK_Product_ProductModel_ProductModelID
        public virtual ICollection<ProductionProductModelIllustration> ProductionProductModelIllustration { get; set; } // Many to many mapping
        public virtual ICollection<ProductionProductModelProductDescriptionCulture> ProductionProductModelProductDescriptionCulture { get; set; } // Many to many mapping

        public ProductionProductModel()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            ProductionProduct = new List<ProductionProduct>();
            ProductionProductModelIllustration = new List<ProductionProductModelIllustration>();
            ProductionProductModelProductDescriptionCulture = new List<ProductionProductModelProductDescriptionCulture>();
        }
    }

    // ProductModelIllustration
    public class ProductionProductModelIllustration
    {
        public int ProductModelId { get; set; } // ProductModelID (Primary key). Primary key. Foreign key to ProductModel.ProductModelID.
        public int IllustrationId { get; set; } // IllustrationID (Primary key). Primary key. Foreign key to Illustration.IllustrationID.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual ProductionIllustration ProductionIllustration { get; set; } // FK_ProductModelIllustration_Illustration_IllustrationID
        public virtual ProductionProductModel ProductionProductModel { get; set; } // FK_ProductModelIllustration_ProductModel_ProductModelID

        public ProductionProductModelIllustration()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

    // ProductModelProductDescriptionCulture
    public class ProductionProductModelProductDescriptionCulture
    {
        public int ProductModelId { get; set; } // ProductModelID (Primary key). Primary key. Foreign key to ProductModel.ProductModelID.
        public int ProductDescriptionId { get; set; } // ProductDescriptionID (Primary key). Primary key. Foreign key to ProductDescription.ProductDescriptionID.
        public string CultureId { get; set; } // CultureID (Primary key). Culture identification number. Foreign key to Culture.CultureID.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual ProductionCulture ProductionCulture { get; set; } // FK_ProductModelProductDescriptionCulture_Culture_CultureID
        public virtual ProductionProductDescription ProductionProductDescription { get; set; } // FK_ProductModelProductDescriptionCulture_ProductDescription_ProductDescriptionID
        public virtual ProductionProductModel ProductionProductModel { get; set; } // FK_ProductModelProductDescriptionCulture_ProductModel_ProductModelID

        public ProductionProductModelProductDescriptionCulture()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

    // ProductPhoto
    public class ProductionProductPhoto
    {
        public int ProductPhotoId { get; set; } // ProductPhotoID (Primary key). Primary key for ProductPhoto records.
        public byte[] ThumbNailPhoto { get; set; } // ThumbNailPhoto. Small image of the product.
        public string ThumbnailPhotoFileName { get; set; } // ThumbnailPhotoFileName. Small image file name.
        public byte[] LargePhoto { get; set; } // LargePhoto. Large image of the product.
        public string LargePhotoFileName { get; set; } // LargePhotoFileName. Large image file name.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<ProductionProductProductPhoto> ProductionProductProductPhoto { get; set; } // Many to many mapping

        public ProductionProductPhoto()
        {
            ModifiedDate = System.DateTime.Now;
            ProductionProductProductPhoto = new List<ProductionProductProductPhoto>();
        }
    }

    // ProductProductPhoto
    public class ProductionProductProductPhoto
    {
        public int ProductId { get; set; } // ProductID (Primary key). Product identification number. Foreign key to Product.ProductID.
        public int ProductPhotoId { get; set; } // ProductPhotoID (Primary key). Product photo identification number. Foreign key to ProductPhoto.ProductPhotoID.
        public bool Primary { get; set; } // Primary. 0 = Photo is not the principal image. 1 = Photo is the principal image.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual ProductionProduct ProductionProduct { get; set; } // FK_ProductProductPhoto_Product_ProductID
        public virtual ProductionProductPhoto ProductionProductPhoto { get; set; } // FK_ProductProductPhoto_ProductPhoto_ProductPhotoID

        public ProductionProductProductPhoto()
        {
            Primary = false;
            ModifiedDate = System.DateTime.Now;
        }
    }

    // ProductReview
    public class ProductionProductReview
    {
        public int ProductReviewId { get; set; } // ProductReviewID (Primary key). Primary key for ProductReview records.
        public int ProductId { get; set; } // ProductID. Product identification number. Foreign key to Product.ProductID.
        public string ReviewerName { get; set; } // ReviewerName. Name of the reviewer.
        public DateTime ReviewDate { get; set; } // ReviewDate. Date review was submitted.
        public string EmailAddress { get; set; } // EmailAddress. Reviewer's e-mail address.
        public int Rating { get; set; } // Rating. Product rating given by the reviewer. Scale is 1 to 5 with 5 as the highest rating.
        public string Comments { get; set; } // Comments. Reviewer's comments
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual ProductionProduct ProductionProduct { get; set; } // FK_ProductReview_Product_ProductID

        public ProductionProductReview()
        {
            ReviewDate = System.DateTime.Now;
            ModifiedDate = System.DateTime.Now;
        }
    }

    // ProductSubcategory
    public class ProductionProductSubcategory
    {
        public int ProductSubcategoryId { get; set; } // ProductSubcategoryID (Primary key). Primary key for ProductSubcategory records.
        public int ProductCategoryId { get; set; } // ProductCategoryID. Product category identification number. Foreign key to ProductCategory.ProductCategoryID.
        public string Name { get; set; } // Name. Subcategory description.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<ProductionProduct> ProductionProduct { get; set; } // Product.FK_Product_ProductSubcategory_ProductSubcategoryID

        // Foreign keys
        public virtual ProductionProductCategory ProductionProductCategory { get; set; } // FK_ProductSubcategory_ProductCategory_ProductCategoryID

        public ProductionProductSubcategory()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            ProductionProduct = new List<ProductionProduct>();
        }
    }

    // ScrapReason
    public class ProductionScrapReason
    {
        public short ScrapReasonId { get; set; } // ScrapReasonID (Primary key). Primary key for ScrapReason records.
        public string Name { get; set; } // Name. Failure description.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<ProductionWorkOrder> ProductionWorkOrder { get; set; } // WorkOrder.FK_WorkOrder_ScrapReason_ScrapReasonID

        public ProductionScrapReason()
        {
            ModifiedDate = System.DateTime.Now;
            ProductionWorkOrder = new List<ProductionWorkOrder>();
        }
    }

    // TransactionHistory
    public class ProductionTransactionHistory
    {
        public int TransactionId { get; set; } // TransactionID (Primary key). Primary key for TransactionHistory records.
        public int ProductId { get; set; } // ProductID. Product identification number. Foreign key to Product.ProductID.
        public int ReferenceOrderId { get; set; } // ReferenceOrderID. Purchase order, sales order, or work order identification number.
        public int ReferenceOrderLineId { get; set; } // ReferenceOrderLineID. Line number associated with the purchase order, sales order, or work order.
        public DateTime TransactionDate { get; set; } // TransactionDate. Date and time of the transaction.
        public string TransactionType { get; set; } // TransactionType. W = WorkOrder, S = SalesOrder, P = PurchaseOrder
        public int Quantity { get; set; } // Quantity. Product quantity.
        public decimal ActualCost { get; set; } // ActualCost. Product cost.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual ProductionProduct ProductionProduct { get; set; } // FK_TransactionHistory_Product_ProductID

        public ProductionTransactionHistory()
        {
            ReferenceOrderLineId = 0;
            TransactionDate = System.DateTime.Now;
            ModifiedDate = System.DateTime.Now;
        }
    }

    // TransactionHistoryArchive
    public class ProductionTransactionHistoryArchive
    {
        public int TransactionId { get; set; } // TransactionID (Primary key). Primary key for TransactionHistoryArchive records.
        public int ProductId { get; set; } // ProductID. Product identification number. Foreign key to Product.ProductID.
        public int ReferenceOrderId { get; set; } // ReferenceOrderID. Purchase order, sales order, or work order identification number.
        public int ReferenceOrderLineId { get; set; } // ReferenceOrderLineID. Line number associated with the purchase order, sales order, or work order.
        public DateTime TransactionDate { get; set; } // TransactionDate. Date and time of the transaction.
        public string TransactionType { get; set; } // TransactionType. W = Work Order, S = Sales Order, P = Purchase Order
        public int Quantity { get; set; } // Quantity. Product quantity.
        public decimal ActualCost { get; set; } // ActualCost. Product cost.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        public ProductionTransactionHistoryArchive()
        {
            ReferenceOrderLineId = 0;
            TransactionDate = System.DateTime.Now;
            ModifiedDate = System.DateTime.Now;
        }
    }

    // UnitMeasure
    public class ProductionUnitMeasure
    {
        public string UnitMeasureCode { get; set; } // UnitMeasureCode (Primary key). Primary key.
        public string Name { get; set; } // Name. Unit of measure description.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<ProductionBillOfMaterials> ProductionBillOfMaterials { get; set; } // BillOfMaterials.FK_BillOfMaterials_UnitMeasure_UnitMeasureCode
        public virtual ICollection<ProductionProduct> ProductionProduct_SizeUnitMeasureCode { get; set; } // Product.FK_Product_UnitMeasure_SizeUnitMeasureCode
        public virtual ICollection<ProductionProduct> ProductionProduct_WeightUnitMeasureCode { get; set; } // Product.FK_Product_UnitMeasure_WeightUnitMeasureCode
        public virtual ICollection<PurchasingProductVendor> PurchasingProductVendor { get; set; } // ProductVendor.FK_ProductVendor_UnitMeasure_UnitMeasureCode

        public ProductionUnitMeasure()
        {
            ModifiedDate = System.DateTime.Now;
            ProductionBillOfMaterials = new List<ProductionBillOfMaterials>();
            ProductionProduct_SizeUnitMeasureCode = new List<ProductionProduct>();
            ProductionProduct_WeightUnitMeasureCode = new List<ProductionProduct>();
            PurchasingProductVendor = new List<PurchasingProductVendor>();
        }
    }

    // WorkOrder
    public class ProductionWorkOrder
    {
        public int WorkOrderId { get; set; } // WorkOrderID (Primary key). Primary key for WorkOrder records.
        public int ProductId { get; set; } // ProductID. Product identification number. Foreign key to Product.ProductID.
        public int OrderQty { get; set; } // OrderQty. Product quantity to build.
        public int StockedQty { get; internal set; } // StockedQty. Quantity built and put in inventory.
        public short ScrappedQty { get; set; } // ScrappedQty. Quantity that failed inspection.
        public DateTime StartDate { get; set; } // StartDate. Work order start date.
        public DateTime? EndDate { get; set; } // EndDate. Work order end date.
        public DateTime DueDate { get; set; } // DueDate. Work order due date.
        public short? ScrapReasonId { get; set; } // ScrapReasonID. Reason for inspection failure.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<ProductionWorkOrderRouting> ProductionWorkOrderRouting { get; set; } // Many to many mapping

        // Foreign keys
        public virtual ProductionProduct ProductionProduct { get; set; } // FK_WorkOrder_Product_ProductID
        public virtual ProductionScrapReason ProductionScrapReason { get; set; } // FK_WorkOrder_ScrapReason_ScrapReasonID

        public ProductionWorkOrder()
        {
            ModifiedDate = System.DateTime.Now;
            ProductionWorkOrderRouting = new List<ProductionWorkOrderRouting>();
        }
    }

    // WorkOrderRouting
    public class ProductionWorkOrderRouting
    {
        public int WorkOrderId { get; set; } // WorkOrderID (Primary key). Primary key. Foreign key to WorkOrder.WorkOrderID.
        public int ProductId { get; set; } // ProductID (Primary key). Primary key. Foreign key to Product.ProductID.
        public short OperationSequence { get; set; } // OperationSequence (Primary key). Primary key. Indicates the manufacturing process sequence.
        public short LocationId { get; set; } // LocationID. Manufacturing location where the part is processed. Foreign key to Location.LocationID.
        public DateTime ScheduledStartDate { get; set; } // ScheduledStartDate. Planned manufacturing start date.
        public DateTime ScheduledEndDate { get; set; } // ScheduledEndDate. Planned manufacturing end date.
        public DateTime? ActualStartDate { get; set; } // ActualStartDate. Actual start date.
        public DateTime? ActualEndDate { get; set; } // ActualEndDate. Actual end date.
        public decimal? ActualResourceHrs { get; set; } // ActualResourceHrs. Number of manufacturing hours used.
        public decimal PlannedCost { get; set; } // PlannedCost. Estimated manufacturing cost.
        public decimal? ActualCost { get; set; } // ActualCost. Actual manufacturing cost.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual ProductionLocation ProductionLocation { get; set; } // FK_WorkOrderRouting_Location_LocationID
        public virtual ProductionWorkOrder ProductionWorkOrder { get; set; } // FK_WorkOrderRouting_WorkOrder_WorkOrderID

        public ProductionWorkOrderRouting()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

    // ProductVendor
    public class PurchasingProductVendor
    {
        public int ProductId { get; set; } // ProductID (Primary key). Primary key. Foreign key to Product.ProductID.
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Primary key. Foreign key to Vendor.BusinessEntityID.
        public int AverageLeadTime { get; set; } // AverageLeadTime. The average span of time (in days) between placing an order with the vendor and receiving the purchased product.
        public decimal StandardPrice { get; set; } // StandardPrice. The vendor's usual selling price.
        public decimal? LastReceiptCost { get; set; } // LastReceiptCost. The selling price when last purchased.
        public DateTime? LastReceiptDate { get; set; } // LastReceiptDate. Date the product was last received by the vendor.
        public int MinOrderQty { get; set; } // MinOrderQty. The maximum quantity that should be ordered.
        public int MaxOrderQty { get; set; } // MaxOrderQty. The minimum quantity that should be ordered.
        public int? OnOrderQty { get; set; } // OnOrderQty. The quantity currently on order.
        public string UnitMeasureCode { get; set; } // UnitMeasureCode. The product's unit of measure.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual ProductionProduct ProductionProduct { get; set; } // FK_ProductVendor_Product_ProductID
        public virtual ProductionUnitMeasure ProductionUnitMeasure { get; set; } // FK_ProductVendor_UnitMeasure_UnitMeasureCode
        public virtual PurchasingVendor PurchasingVendor { get; set; } // FK_ProductVendor_Vendor_BusinessEntityID

        public PurchasingProductVendor()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

    // PurchaseOrderDetail
    public class PurchasingPurchaseOrderDetail
    {
        public int PurchaseOrderId { get; set; } // PurchaseOrderID (Primary key). Primary key. Foreign key to PurchaseOrderHeader.PurchaseOrderID.
        public int PurchaseOrderDetailId { get; set; } // PurchaseOrderDetailID (Primary key). Primary key. One line number per purchased product.
        public DateTime DueDate { get; set; } // DueDate. Date the product is expected to be received.
        public short OrderQty { get; set; } // OrderQty. Quantity ordered.
        public int ProductId { get; set; } // ProductID. Product identification number. Foreign key to Product.ProductID.
        public decimal UnitPrice { get; set; } // UnitPrice. Vendor's selling price of a single product.
        public decimal LineTotal { get; internal set; } // LineTotal. Per product subtotal. Computed as OrderQty * UnitPrice.
        public decimal ReceivedQty { get; set; } // ReceivedQty. Quantity actually received from the vendor.
        public decimal RejectedQty { get; set; } // RejectedQty. Quantity rejected during inspection.
        public decimal StockedQty { get; internal set; } // StockedQty. Quantity accepted into inventory. Computed as ReceivedQty - RejectedQty.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual ProductionProduct ProductionProduct { get; set; } // FK_PurchaseOrderDetail_Product_ProductID
        public virtual PurchasingPurchaseOrderHeader PurchasingPurchaseOrderHeader { get; set; } // FK_PurchaseOrderDetail_PurchaseOrderHeader_PurchaseOrderID

        public PurchasingPurchaseOrderDetail()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

    // PurchaseOrderHeader
    public class PurchasingPurchaseOrderHeader
    {
        public int PurchaseOrderId { get; set; } // PurchaseOrderID (Primary key). Primary key.
        public byte RevisionNumber { get; set; } // RevisionNumber. Incremental number to track changes to the purchase order over time.
        public byte Status { get; set; } // Status. Order current status. 1 = Pending; 2 = Approved; 3 = Rejected; 4 = Complete
        public int EmployeeId { get; set; } // EmployeeID. Employee who created the purchase order. Foreign key to Employee.BusinessEntityID.
        public int VendorId { get; set; } // VendorID. Vendor with whom the purchase order is placed. Foreign key to Vendor.BusinessEntityID.
        public int ShipMethodId { get; set; } // ShipMethodID. Shipping method. Foreign key to ShipMethod.ShipMethodID.
        public DateTime OrderDate { get; set; } // OrderDate. Purchase order creation date.
        public DateTime? ShipDate { get; set; } // ShipDate. Estimated shipment date from the vendor.
        public decimal SubTotal { get; set; } // SubTotal. Purchase order subtotal. Computed as SUM(PurchaseOrderDetail.LineTotal)for the appropriate PurchaseOrderID.
        public decimal TaxAmt { get; set; } // TaxAmt. Tax amount.
        public decimal Freight { get; set; } // Freight. Shipping cost.
        public decimal TotalDue { get; internal set; } // TotalDue. Total due to vendor. Computed as Subtotal + TaxAmt + Freight.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<PurchasingPurchaseOrderDetail> PurchasingPurchaseOrderDetail { get; set; } // Many to many mapping

        // Foreign keys
        public virtual HumanResourcesEmployee HumanResourcesEmployee { get; set; } // FK_PurchaseOrderHeader_Employee_EmployeeID
        public virtual PurchasingShipMethod PurchasingShipMethod { get; set; } // FK_PurchaseOrderHeader_ShipMethod_ShipMethodID
        public virtual PurchasingVendor PurchasingVendor { get; set; } // FK_PurchaseOrderHeader_Vendor_VendorID

        public PurchasingPurchaseOrderHeader()
        {
            RevisionNumber = 0;
            Status = 1;
            OrderDate = System.DateTime.Now;
            SubTotal = 0.00m;
            TaxAmt = 0.00m;
            Freight = 0.00m;
            ModifiedDate = System.DateTime.Now;
            PurchasingPurchaseOrderDetail = new List<PurchasingPurchaseOrderDetail>();
        }
    }

    // ShipMethod
    public class PurchasingShipMethod
    {
        public int ShipMethodId { get; set; } // ShipMethodID (Primary key). Primary key for ShipMethod records.
        public string Name { get; set; } // Name. Shipping company name.
        public decimal ShipBase { get; set; } // ShipBase. Minimum shipping charge.
        public decimal ShipRate { get; set; } // ShipRate. Shipping charge per pound.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<PurchasingPurchaseOrderHeader> PurchasingPurchaseOrderHeader { get; set; } // PurchaseOrderHeader.FK_PurchaseOrderHeader_ShipMethod_ShipMethodID
        public virtual ICollection<SalesSalesOrderHeader> SalesSalesOrderHeader { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_ShipMethod_ShipMethodID

        public PurchasingShipMethod()
        {
            ShipBase = 0.00m;
            ShipRate = 0.00m;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            PurchasingPurchaseOrderHeader = new List<PurchasingPurchaseOrderHeader>();
            SalesSalesOrderHeader = new List<SalesSalesOrderHeader>();
        }
    }

    // Vendor
    public class PurchasingVendor
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Primary key for Vendor records.  Foreign key to BusinessEntity.BusinessEntityID
        public string AccountNumber { get; set; } // AccountNumber. Vendor account (identification) number.
        public string Name { get; set; } // Name. Company name.
        public byte CreditRating { get; set; } // CreditRating. 1 = Superior, 2 = Excellent, 3 = Above average, 4 = Average, 5 = Below average
        public bool PreferredVendorStatus { get; set; } // PreferredVendorStatus. 0 = Do not use if another vendor is available. 1 = Preferred over other vendors supplying the same product.
        public bool ActiveFlag { get; set; } // ActiveFlag. 0 = Vendor no longer used. 1 = Vendor is actively used.
        public string PurchasingWebServiceUrl { get; set; } // PurchasingWebServiceURL. Vendor URL.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<PurchasingProductVendor> PurchasingProductVendor { get; set; } // Many to many mapping
        public virtual ICollection<PurchasingPurchaseOrderHeader> PurchasingPurchaseOrderHeader { get; set; } // PurchaseOrderHeader.FK_PurchaseOrderHeader_Vendor_VendorID

        // Foreign keys
        public virtual PersonBusinessEntity PersonBusinessEntity { get; set; } // FK_Vendor_BusinessEntity_BusinessEntityID

        public PurchasingVendor()
        {
            PreferredVendorStatus = true;
            ActiveFlag = true;
            ModifiedDate = System.DateTime.Now;
            PurchasingProductVendor = new List<PurchasingProductVendor>();
            PurchasingPurchaseOrderHeader = new List<PurchasingPurchaseOrderHeader>();
        }
    }

    // CountryRegionCurrency
    public class SalesCountryRegionCurrency
    {
        public string CountryRegionCode { get; set; } // CountryRegionCode (Primary key). ISO code for countries and regions. Foreign key to CountryRegion.CountryRegionCode.
        public string CurrencyCode { get; set; } // CurrencyCode (Primary key). ISO standard currency code. Foreign key to Currency.CurrencyCode.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual PersonCountryRegion PersonCountryRegion { get; set; } // FK_CountryRegionCurrency_CountryRegion_CountryRegionCode
        public virtual SalesCurrency SalesCurrency { get; set; } // FK_CountryRegionCurrency_Currency_CurrencyCode

        public SalesCountryRegionCurrency()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

    // CreditCard
    public class SalesCreditCard
    {
        public int CreditCardId { get; set; } // CreditCardID (Primary key). Primary key for CreditCard records.
        public string CardType { get; set; } // CardType. Credit card name.
        public string CardNumber { get; set; } // CardNumber. Credit card number.
        public byte ExpMonth { get; set; } // ExpMonth. Credit card expiration month.
        public short ExpYear { get; set; } // ExpYear. Credit card expiration year.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<SalesPersonCreditCard> SalesPersonCreditCard { get; set; } // Many to many mapping
        public virtual ICollection<SalesSalesOrderHeader> SalesSalesOrderHeader { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_CreditCard_CreditCardID

        public SalesCreditCard()
        {
            ModifiedDate = System.DateTime.Now;
            SalesPersonCreditCard = new List<SalesPersonCreditCard>();
            SalesSalesOrderHeader = new List<SalesSalesOrderHeader>();
        }
    }

    // Currency
    public class SalesCurrency
    {
        public string CurrencyCode { get; set; } // CurrencyCode (Primary key). The ISO code for the Currency.
        public string Name { get; set; } // Name. Currency name.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<SalesCountryRegionCurrency> SalesCountryRegionCurrency { get; set; } // Many to many mapping
        public virtual ICollection<SalesCurrencyRate> SalesCurrencyRate_FromCurrencyCode { get; set; } // CurrencyRate.FK_CurrencyRate_Currency_FromCurrencyCode
        public virtual ICollection<SalesCurrencyRate> SalesCurrencyRate_ToCurrencyCode { get; set; } // CurrencyRate.FK_CurrencyRate_Currency_ToCurrencyCode

        public SalesCurrency()
        {
            ModifiedDate = System.DateTime.Now;
            SalesCountryRegionCurrency = new List<SalesCountryRegionCurrency>();
            SalesCurrencyRate_FromCurrencyCode = new List<SalesCurrencyRate>();
            SalesCurrencyRate_ToCurrencyCode = new List<SalesCurrencyRate>();
        }
    }

    // CurrencyRate
    public class SalesCurrencyRate
    {
        public int CurrencyRateId { get; set; } // CurrencyRateID (Primary key). Primary key for CurrencyRate records.
        public DateTime CurrencyRateDate { get; set; } // CurrencyRateDate. Date and time the exchange rate was obtained.
        public string FromCurrencyCode { get; set; } // FromCurrencyCode. Exchange rate was converted from this currency code.
        public string ToCurrencyCode { get; set; } // ToCurrencyCode. Exchange rate was converted to this currency code.
        public decimal AverageRate { get; set; } // AverageRate. Average exchange rate for the day.
        public decimal EndOfDayRate { get; set; } // EndOfDayRate. Final exchange rate for the day.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<SalesSalesOrderHeader> SalesSalesOrderHeader { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_CurrencyRate_CurrencyRateID

        // Foreign keys
        public virtual SalesCurrency SalesCurrency_FromCurrencyCode { get; set; } // FK_CurrencyRate_Currency_FromCurrencyCode
        public virtual SalesCurrency SalesCurrency_ToCurrencyCode { get; set; } // FK_CurrencyRate_Currency_ToCurrencyCode

        public SalesCurrencyRate()
        {
            ModifiedDate = System.DateTime.Now;
            SalesSalesOrderHeader = new List<SalesSalesOrderHeader>();
        }
    }

    // Customer
    public class SalesCustomer
    {
        public int CustomerId { get; set; } // CustomerID (Primary key). Primary key.
        public int? PersonId { get; set; } // PersonID. Foreign key to Person.BusinessEntityID
        public int? StoreId { get; set; } // StoreID. Foreign key to Store.BusinessEntityID
        public int? TerritoryId { get; set; } // TerritoryID. ID of the territory in which the customer is located. Foreign key to SalesTerritory.SalesTerritoryID.
        public string AccountNumber { get; internal set; } // AccountNumber. Unique number identifying the customer assigned by the accounting system.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<SalesSalesOrderHeader> SalesSalesOrderHeader { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_Customer_CustomerID

        // Foreign keys
        public virtual PersonPerson PersonPerson { get; set; } // FK_Customer_Person_PersonID
        public virtual SalesSalesTerritory SalesSalesTerritory { get; set; } // FK_Customer_SalesTerritory_TerritoryID
        public virtual SalesStore SalesStore { get; set; } // FK_Customer_Store_StoreID

        public SalesCustomer()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            SalesSalesOrderHeader = new List<SalesSalesOrderHeader>();
        }
    }

    // PersonCreditCard
    public class SalesPersonCreditCard
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Business entity identification number. Foreign key to Person.BusinessEntityID.
        public int CreditCardId { get; set; } // CreditCardID (Primary key). Credit card identification number. Foreign key to CreditCard.CreditCardID.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual PersonPerson PersonPerson { get; set; } // FK_PersonCreditCard_Person_BusinessEntityID
        public virtual SalesCreditCard SalesCreditCard { get; set; } // FK_PersonCreditCard_CreditCard_CreditCardID

        public SalesPersonCreditCard()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

    // SalesOrderDetail
    public class SalesSalesOrderDetail
    {
        public int SalesOrderId { get; set; } // SalesOrderID (Primary key). Primary key. Foreign key to SalesOrderHeader.SalesOrderID.
        public int SalesOrderDetailId { get; set; } // SalesOrderDetailID (Primary key). Primary key. One incremental unique number per product sold.
        public string CarrierTrackingNumber { get; set; } // CarrierTrackingNumber. Shipment tracking number supplied by the shipper.
        public short OrderQty { get; set; } // OrderQty. Quantity ordered per product.
        public int ProductId { get; set; } // ProductID. Product sold to customer. Foreign key to Product.ProductID.
        public int SpecialOfferId { get; set; } // SpecialOfferID. Promotional code. Foreign key to SpecialOffer.SpecialOfferID.
        public decimal UnitPrice { get; set; } // UnitPrice. Selling price of a single product.
        public decimal UnitPriceDiscount { get; set; } // UnitPriceDiscount. Discount amount.
        public decimal LineTotal { get; internal set; } // LineTotal. Per product subtotal. Computed as UnitPrice * (1 - UnitPriceDiscount) * OrderQty.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual SalesSalesOrderHeader SalesSalesOrderHeader { get; set; } // FK_SalesOrderDetail_SalesOrderHeader_SalesOrderID
        public virtual SalesSpecialOfferProduct SalesSpecialOfferProduct { get; set; } // FK_SalesOrderDetail_SpecialOfferProduct_SpecialOfferIDProductID

        public SalesSalesOrderDetail()
        {
            UnitPriceDiscount = 0.0m;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
        }
    }

    // SalesOrderHeader
    public class SalesSalesOrderHeader
    {
        public int SalesOrderId { get; set; } // SalesOrderID (Primary key). Primary key.
        public byte RevisionNumber { get; set; } // RevisionNumber. Incremental number to track changes to the sales order over time.
        public DateTime OrderDate { get; set; } // OrderDate. Dates the sales order was created.
        public DateTime DueDate { get; set; } // DueDate. Date the order is due to the customer.
        public DateTime? ShipDate { get; set; } // ShipDate. Date the order was shipped to the customer.
        public byte Status { get; set; } // Status. Order current status. 1 = In process; 2 = Approved; 3 = Backordered; 4 = Rejected; 5 = Shipped; 6 = Cancelled
        public bool OnlineOrderFlag { get; set; } // OnlineOrderFlag. 0 = Order placed by sales person. 1 = Order placed online by customer.
        public string SalesOrderNumber { get; internal set; } // SalesOrderNumber. Unique sales order identification number.
        public string PurchaseOrderNumber { get; set; } // PurchaseOrderNumber. Customer purchase order number reference.
        public string AccountNumber { get; set; } // AccountNumber. Financial accounting number reference.
        public int CustomerId { get; set; } // CustomerID. Customer identification number. Foreign key to Customer.BusinessEntityID.
        public int? SalesPersonId { get; set; } // SalesPersonID. Sales person who created the sales order. Foreign key to SalesPerson.BusinessEntityID.
        public int? TerritoryId { get; set; } // TerritoryID. Territory in which the sale was made. Foreign key to SalesTerritory.SalesTerritoryID.
        public int BillToAddressId { get; set; } // BillToAddressID. Customer billing address. Foreign key to Address.AddressID.
        public int ShipToAddressId { get; set; } // ShipToAddressID. Customer shipping address. Foreign key to Address.AddressID.
        public int ShipMethodId { get; set; } // ShipMethodID. Shipping method. Foreign key to ShipMethod.ShipMethodID.
        public int? CreditCardId { get; set; } // CreditCardID. Credit card identification number. Foreign key to CreditCard.CreditCardID.
        public string CreditCardApprovalCode { get; set; } // CreditCardApprovalCode. Approval code provided by the credit card company.
        public int? CurrencyRateId { get; set; } // CurrencyRateID. Currency exchange rate used. Foreign key to CurrencyRate.CurrencyRateID.
        public decimal SubTotal { get; set; } // SubTotal. Sales subtotal. Computed as SUM(SalesOrderDetail.LineTotal)for the appropriate SalesOrderID.
        public decimal TaxAmt { get; set; } // TaxAmt. Tax amount.
        public decimal Freight { get; set; } // Freight. Shipping cost.
        public decimal TotalDue { get; internal set; } // TotalDue. Total due from customer. Computed as Subtotal + TaxAmt + Freight.
        public string Comment { get; set; } // Comment. Sales representative comments.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<SalesSalesOrderDetail> SalesSalesOrderDetail { get; set; } // Many to many mapping
        public virtual ICollection<SalesSalesOrderHeaderSalesReason> SalesSalesOrderHeaderSalesReason { get; set; } // Many to many mapping

        // Foreign keys
        public virtual PersonAddress PersonAddress_BillToAddressId { get; set; } // FK_SalesOrderHeader_Address_BillToAddressID
        public virtual PersonAddress PersonAddress_ShipToAddressId { get; set; } // FK_SalesOrderHeader_Address_ShipToAddressID
        public virtual PurchasingShipMethod PurchasingShipMethod { get; set; } // FK_SalesOrderHeader_ShipMethod_ShipMethodID
        public virtual SalesCreditCard SalesCreditCard { get; set; } // FK_SalesOrderHeader_CreditCard_CreditCardID
        public virtual SalesCurrencyRate SalesCurrencyRate { get; set; } // FK_SalesOrderHeader_CurrencyRate_CurrencyRateID
        public virtual SalesCustomer SalesCustomer { get; set; } // FK_SalesOrderHeader_Customer_CustomerID
        public virtual SalesSalesPerson SalesSalesPerson { get; set; } // FK_SalesOrderHeader_SalesPerson_SalesPersonID
        public virtual SalesSalesTerritory SalesSalesTerritory { get; set; } // FK_SalesOrderHeader_SalesTerritory_TerritoryID

        public SalesSalesOrderHeader()
        {
            RevisionNumber = 0;
            OrderDate = System.DateTime.Now;
            Status = 1;
            OnlineOrderFlag = true;
            SubTotal = 0.00m;
            TaxAmt = 0.00m;
            Freight = 0.00m;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            SalesSalesOrderDetail = new List<SalesSalesOrderDetail>();
            SalesSalesOrderHeaderSalesReason = new List<SalesSalesOrderHeaderSalesReason>();
        }
    }

    // SalesOrderHeaderSalesReason
    public class SalesSalesOrderHeaderSalesReason
    {
        public int SalesOrderId { get; set; } // SalesOrderID (Primary key). Primary key. Foreign key to SalesOrderHeader.SalesOrderID.
        public int SalesReasonId { get; set; } // SalesReasonID (Primary key). Primary key. Foreign key to SalesReason.SalesReasonID.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual SalesSalesOrderHeader SalesSalesOrderHeader { get; set; } // FK_SalesOrderHeaderSalesReason_SalesOrderHeader_SalesOrderID
        public virtual SalesSalesReason SalesSalesReason { get; set; } // FK_SalesOrderHeaderSalesReason_SalesReason_SalesReasonID

        public SalesSalesOrderHeaderSalesReason()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

    // SalesPerson
    public class SalesSalesPerson
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Primary key for SalesPerson records. Foreign key to Employee.BusinessEntityID
        public int? TerritoryId { get; set; } // TerritoryID. Territory currently assigned to. Foreign key to SalesTerritory.SalesTerritoryID.
        public decimal? SalesQuota { get; set; } // SalesQuota. Projected yearly sales.
        public decimal Bonus { get; set; } // Bonus. Bonus due if quota is met.
        public decimal CommissionPct { get; set; } // CommissionPct. Commision percent received per sale.
        public decimal SalesYtd { get; set; } // SalesYTD. Sales total year to date.
        public decimal SalesLastYear { get; set; } // SalesLastYear. Sales total of previous year.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<SalesSalesOrderHeader> SalesSalesOrderHeader { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_SalesPerson_SalesPersonID
        public virtual ICollection<SalesSalesPersonQuotaHistory> SalesSalesPersonQuotaHistory { get; set; } // Many to many mapping
        public virtual ICollection<SalesSalesTerritoryHistory> SalesSalesTerritoryHistory { get; set; } // Many to many mapping
        public virtual ICollection<SalesStore> SalesStore { get; set; } // Store.FK_Store_SalesPerson_SalesPersonID

        // Foreign keys
        public virtual HumanResourcesEmployee HumanResourcesEmployee { get; set; } // FK_SalesPerson_Employee_BusinessEntityID
        public virtual SalesSalesTerritory SalesSalesTerritory { get; set; } // FK_SalesPerson_SalesTerritory_TerritoryID

        public SalesSalesPerson()
        {
            Bonus = 0.00m;
            CommissionPct = 0.00m;
            SalesYtd = 0.00m;
            SalesLastYear = 0.00m;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            SalesSalesOrderHeader = new List<SalesSalesOrderHeader>();
            SalesSalesPersonQuotaHistory = new List<SalesSalesPersonQuotaHistory>();
            SalesSalesTerritoryHistory = new List<SalesSalesTerritoryHistory>();
            SalesStore = new List<SalesStore>();
        }
    }

    // SalesPersonQuotaHistory
    public class SalesSalesPersonQuotaHistory
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Sales person identification number. Foreign key to SalesPerson.BusinessEntityID.
        public DateTime QuotaDate { get; set; } // QuotaDate (Primary key). Sales quota date.
        public decimal SalesQuota { get; set; } // SalesQuota. Sales quota amount.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual SalesSalesPerson SalesSalesPerson { get; set; } // FK_SalesPersonQuotaHistory_SalesPerson_BusinessEntityID

        public SalesSalesPersonQuotaHistory()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
        }
    }

    // SalesReason
    public class SalesSalesReason
    {
        public int SalesReasonId { get; set; } // SalesReasonID (Primary key). Primary key for SalesReason records.
        public string Name { get; set; } // Name. Sales reason description.
        public string ReasonType { get; set; } // ReasonType. Category the sales reason belongs to.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<SalesSalesOrderHeaderSalesReason> SalesSalesOrderHeaderSalesReason { get; set; } // Many to many mapping

        public SalesSalesReason()
        {
            ModifiedDate = System.DateTime.Now;
            SalesSalesOrderHeaderSalesReason = new List<SalesSalesOrderHeaderSalesReason>();
        }
    }

    // SalesTaxRate
    public class SalesSalesTaxRate
    {
        public int SalesTaxRateId { get; set; } // SalesTaxRateID (Primary key). Primary key for SalesTaxRate records.
        public int StateProvinceId { get; set; } // StateProvinceID. State, province, or country/region the sales tax applies to.
        public byte TaxType { get; set; } // TaxType. 1 = Tax applied to retail transactions, 2 = Tax applied to wholesale transactions, 3 = Tax applied to all sales (retail and wholesale) transactions.
        public decimal TaxRate { get; set; } // TaxRate. Tax rate amount.
        public string Name { get; set; } // Name. Tax rate description.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual PersonStateProvince PersonStateProvince { get; set; } // FK_SalesTaxRate_StateProvince_StateProvinceID

        public SalesSalesTaxRate()
        {
            TaxRate = 0.00m;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
        }
    }

    // SalesTerritory
    public class SalesSalesTerritory
    {
        public int TerritoryId { get; set; } // TerritoryID (Primary key). Primary key for SalesTerritory records.
        public string Name { get; set; } // Name. Sales territory description
        public string CountryRegionCode { get; set; } // CountryRegionCode. ISO standard country or region code. Foreign key to CountryRegion.CountryRegionCode.
        public string Group { get; set; } // Group. Geographic area to which the sales territory belong.
        public decimal SalesYtd { get; set; } // SalesYTD. Sales in the territory year to date.
        public decimal SalesLastYear { get; set; } // SalesLastYear. Sales in the territory the previous year.
        public decimal CostYtd { get; set; } // CostYTD. Business costs in the territory year to date.
        public decimal CostLastYear { get; set; } // CostLastYear. Business costs in the territory the previous year.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<PersonStateProvince> PersonStateProvince { get; set; } // StateProvince.FK_StateProvince_SalesTerritory_TerritoryID
        public virtual ICollection<SalesCustomer> SalesCustomer { get; set; } // Customer.FK_Customer_SalesTerritory_TerritoryID
        public virtual ICollection<SalesSalesOrderHeader> SalesSalesOrderHeader { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_SalesTerritory_TerritoryID
        public virtual ICollection<SalesSalesPerson> SalesSalesPerson { get; set; } // SalesPerson.FK_SalesPerson_SalesTerritory_TerritoryID
        public virtual ICollection<SalesSalesTerritoryHistory> SalesSalesTerritoryHistory { get; set; } // Many to many mapping

        // Foreign keys
        public virtual PersonCountryRegion PersonCountryRegion { get; set; } // FK_SalesTerritory_CountryRegion_CountryRegionCode

        public SalesSalesTerritory()
        {
            SalesYtd = 0.00m;
            SalesLastYear = 0.00m;
            CostYtd = 0.00m;
            CostLastYear = 0.00m;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            SalesCustomer = new List<SalesCustomer>();
            SalesSalesOrderHeader = new List<SalesSalesOrderHeader>();
            SalesSalesPerson = new List<SalesSalesPerson>();
            SalesSalesTerritoryHistory = new List<SalesSalesTerritoryHistory>();
            PersonStateProvince = new List<PersonStateProvince>();
        }
    }

    // SalesTerritoryHistory
    public class SalesSalesTerritoryHistory
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Primary key. The sales rep.  Foreign key to SalesPerson.BusinessEntityID.
        public int TerritoryId { get; set; } // TerritoryID (Primary key). Primary key. Territory identification number. Foreign key to SalesTerritory.SalesTerritoryID.
        public DateTime StartDate { get; set; } // StartDate (Primary key). Primary key. Date the sales representive started work in the territory.
        public DateTime? EndDate { get; set; } // EndDate. Date the sales representative left work in the territory.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual SalesSalesPerson SalesSalesPerson { get; set; } // FK_SalesTerritoryHistory_SalesPerson_BusinessEntityID
        public virtual SalesSalesTerritory SalesSalesTerritory { get; set; } // FK_SalesTerritoryHistory_SalesTerritory_TerritoryID

        public SalesSalesTerritoryHistory()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
        }
    }

    // ShoppingCartItem
    public class SalesShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; } // ShoppingCartItemID (Primary key). Primary key for ShoppingCartItem records.
        public string ShoppingCartId { get; set; } // ShoppingCartID. Shopping cart identification number.
        public int Quantity { get; set; } // Quantity. Product quantity ordered.
        public int ProductId { get; set; } // ProductID. Product ordered. Foreign key to Product.ProductID.
        public DateTime DateCreated { get; set; } // DateCreated. Date the time the record was created.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Foreign keys
        public virtual ProductionProduct ProductionProduct { get; set; } // FK_ShoppingCartItem_Product_ProductID

        public SalesShoppingCartItem()
        {
            Quantity = 1;
            DateCreated = System.DateTime.Now;
            ModifiedDate = System.DateTime.Now;
        }
    }

    // SpecialOffer
    public class SalesSpecialOffer
    {
        public int SpecialOfferId { get; set; } // SpecialOfferID (Primary key). Primary key for SpecialOffer records.
        public string Description { get; set; } // Description. Discount description.
        public decimal DiscountPct { get; set; } // DiscountPct. Discount precentage.
        public string Type { get; set; } // Type. Discount type category.
        public string Category { get; set; } // Category. Group the discount applies to such as Reseller or Customer.
        public DateTime StartDate { get; set; } // StartDate. Discount start date.
        public DateTime EndDate { get; set; } // EndDate. Discount end date.
        public int MinQty { get; set; } // MinQty. Minimum discount percent allowed.
        public int? MaxQty { get; set; } // MaxQty. Maximum discount percent allowed.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<SalesSpecialOfferProduct> SalesSpecialOfferProduct { get; set; } // Many to many mapping

        public SalesSpecialOffer()
        {
            DiscountPct = 0.00m;
            MinQty = 0;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            SalesSpecialOfferProduct = new List<SalesSpecialOfferProduct>();
        }
    }

    // SpecialOfferProduct
    public class SalesSpecialOfferProduct
    {
        public int SpecialOfferId { get; set; } // SpecialOfferID (Primary key). Primary key for SpecialOfferProduct records.
        public int ProductId { get; set; } // ProductID (Primary key). Product identification number. Foreign key to Product.ProductID.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<SalesSalesOrderDetail> SalesSalesOrderDetail { get; set; } // Many to many mapping

        // Foreign keys
        public virtual ProductionProduct ProductionProduct { get; set; } // FK_SpecialOfferProduct_Product_ProductID
        public virtual SalesSpecialOffer SalesSpecialOffer { get; set; } // FK_SpecialOfferProduct_SpecialOffer_SpecialOfferID

        public SalesSpecialOfferProduct()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            SalesSalesOrderDetail = new List<SalesSalesOrderDetail>();
        }
    }

    // Store
    public class SalesStore
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key). Primary key. Foreign key to Customer.BusinessEntityID.
        public string Name { get; set; } // Name. Name of the store.
        public int? SalesPersonId { get; set; } // SalesPersonID. ID of the sales person assigned to the customer. Foreign key to SalesPerson.BusinessEntityID.
        public string Demographics { get; set; } // Demographics. Demographic informationg about the store such as the number of employees, annual sales and store type.
        public Guid Rowguid { get; set; } // rowguid. ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        public DateTime ModifiedDate { get; set; } // ModifiedDate. Date and time the record was last updated.

        // Reverse navigation
        public virtual ICollection<SalesCustomer> SalesCustomer { get; set; } // Customer.FK_Customer_Store_StoreID

        // Foreign keys
        public virtual PersonBusinessEntity PersonBusinessEntity { get; set; } // FK_Store_BusinessEntity_BusinessEntityID
        public virtual SalesSalesPerson SalesSalesPerson { get; set; } // FK_Store_SalesPerson_SalesPersonID

        public SalesStore()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            SalesCustomer = new List<SalesCustomer>();
        }
    }


    // ************************************************************************
    // POCO Configuration

    // Department
    internal class HumanResourcesDepartmentConfiguration : EntityTypeConfiguration<HumanResourcesDepartment>
    {
        public HumanResourcesDepartmentConfiguration(string schema = "HumanResources")
        {
            ToTable(schema + ".Department");
            HasKey(x => x.DepartmentId);

            Property(x => x.DepartmentId).HasColumnName("DepartmentID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.GroupName).HasColumnName("GroupName").IsRequired().HasMaxLength(50);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // Employee
    internal class HumanResourcesEmployeeConfiguration : EntityTypeConfiguration<HumanResourcesEmployee>
    {
        public HumanResourcesEmployeeConfiguration(string schema = "HumanResources")
        {
            ToTable(schema + ".Employee");
            HasKey(x => x.BusinessEntityId);

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.NationalIdNumber).HasColumnName("NationalIDNumber").IsRequired().HasMaxLength(15);
            Property(x => x.LoginId).HasColumnName("LoginID").IsRequired().HasMaxLength(256);
            Property(x => x.OrganizationNode).HasColumnName("OrganizationNode").IsOptional();
            Property(x => x.OrganizationLevel).HasColumnName("OrganizationLevel").IsOptional().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.JobTitle).HasColumnName("JobTitle").IsRequired().HasMaxLength(50);
            Property(x => x.BirthDate).HasColumnName("BirthDate").IsRequired();
            Property(x => x.MaritalStatus).HasColumnName("MaritalStatus").IsRequired().IsFixedLength().HasMaxLength(1);
            Property(x => x.Gender).HasColumnName("Gender").IsRequired().IsFixedLength().HasMaxLength(1);
            Property(x => x.HireDate).HasColumnName("HireDate").IsRequired();
            Property(x => x.SalariedFlag).HasColumnName("SalariedFlag").IsRequired();
            Property(x => x.VacationHours).HasColumnName("VacationHours").IsRequired();
            Property(x => x.SickLeaveHours).HasColumnName("SickLeaveHours").IsRequired();
            Property(x => x.CurrentFlag).HasColumnName("CurrentFlag").IsRequired();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.PersonPerson).WithOptional(b => b.HumanResourcesEmployee); // FK_Employee_Person_BusinessEntityID
        }
    }

    // EmployeeDepartmentHistory
    internal class HumanResourcesEmployeeDepartmentHistoryConfiguration : EntityTypeConfiguration<HumanResourcesEmployeeDepartmentHistory>
    {
        public HumanResourcesEmployeeDepartmentHistoryConfiguration(string schema = "HumanResources")
        {
            ToTable(schema + ".EmployeeDepartmentHistory");
            HasKey(x => new { x.BusinessEntityId, x.DepartmentId, x.ShiftId, x.StartDate });

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.DepartmentId).HasColumnName("DepartmentID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ShiftId).HasColumnName("ShiftID").IsRequired();
            Property(x => x.StartDate).HasColumnName("StartDate").IsRequired();
            Property(x => x.EndDate).HasColumnName("EndDate").IsOptional();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.HumanResourcesEmployee).WithMany(b => b.HumanResourcesEmployeeDepartmentHistory).HasForeignKey(c => c.BusinessEntityId); // FK_EmployeeDepartmentHistory_Employee_BusinessEntityID
            HasRequired(a => a.HumanResourcesDepartment).WithMany(b => b.HumanResourcesEmployeeDepartmentHistory).HasForeignKey(c => c.DepartmentId); // FK_EmployeeDepartmentHistory_Department_DepartmentID
            HasRequired(a => a.HumanResourcesShift).WithMany(b => b.HumanResourcesEmployeeDepartmentHistory).HasForeignKey(c => c.ShiftId); // FK_EmployeeDepartmentHistory_Shift_ShiftID
        }
    }

    // EmployeePayHistory
    internal class HumanResourcesEmployeePayHistoryConfiguration : EntityTypeConfiguration<HumanResourcesEmployeePayHistory>
    {
        public HumanResourcesEmployeePayHistoryConfiguration(string schema = "HumanResources")
        {
            ToTable(schema + ".EmployeePayHistory");
            HasKey(x => new { x.BusinessEntityId, x.RateChangeDate });

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.RateChangeDate).HasColumnName("RateChangeDate").IsRequired();
            Property(x => x.Rate).HasColumnName("Rate").IsRequired().HasPrecision(19,4);
            Property(x => x.PayFrequency).HasColumnName("PayFrequency").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.HumanResourcesEmployee).WithMany(b => b.HumanResourcesEmployeePayHistory).HasForeignKey(c => c.BusinessEntityId); // FK_EmployeePayHistory_Employee_BusinessEntityID
        }
    }

    // JobCandidate
    internal class HumanResourcesJobCandidateConfiguration : EntityTypeConfiguration<HumanResourcesJobCandidate>
    {
        public HumanResourcesJobCandidateConfiguration(string schema = "HumanResources")
        {
            ToTable(schema + ".JobCandidate");
            HasKey(x => x.JobCandidateId);

            Property(x => x.JobCandidateId).HasColumnName("JobCandidateID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsOptional();
            Property(x => x.Resume).HasColumnName("Resume").IsOptional();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasOptional(a => a.HumanResourcesEmployee).WithMany(b => b.HumanResourcesJobCandidate).HasForeignKey(c => c.BusinessEntityId); // FK_JobCandidate_Employee_BusinessEntityID
        }
    }

    // Shift
    internal class HumanResourcesShiftConfiguration : EntityTypeConfiguration<HumanResourcesShift>
    {
        public HumanResourcesShiftConfiguration(string schema = "HumanResources")
        {
            ToTable(schema + ".Shift");
            HasKey(x => x.ShiftId);

            Property(x => x.ShiftId).HasColumnName("ShiftID").IsRequired();
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.StartTime).HasColumnName("StartTime").IsRequired();
            Property(x => x.EndTime).HasColumnName("EndTime").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // Address
    internal class PersonAddressConfiguration : EntityTypeConfiguration<PersonAddress>
    {
        public PersonAddressConfiguration(string schema = "Person")
        {
            ToTable(schema + ".Address");
            HasKey(x => x.AddressId);

            Property(x => x.AddressId).HasColumnName("AddressID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.AddressLine1).HasColumnName("AddressLine1").IsRequired().HasMaxLength(60);
            Property(x => x.AddressLine2).HasColumnName("AddressLine2").IsOptional().HasMaxLength(60);
            Property(x => x.City).HasColumnName("City").IsRequired().HasMaxLength(30);
            Property(x => x.StateProvinceId).HasColumnName("StateProvinceID").IsRequired();
            Property(x => x.PostalCode).HasColumnName("PostalCode").IsRequired().HasMaxLength(15);
            Property(x => x.SpatialLocation).HasColumnName("SpatialLocation").IsOptional();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.PersonStateProvince).WithMany(b => b.PersonAddress).HasForeignKey(c => c.StateProvinceId); // FK_Address_StateProvince_StateProvinceID
        }
    }

    // AddressType
    internal class PersonAddressTypeConfiguration : EntityTypeConfiguration<PersonAddressType>
    {
        public PersonAddressTypeConfiguration(string schema = "Person")
        {
            ToTable(schema + ".AddressType");
            HasKey(x => x.AddressTypeId);

            Property(x => x.AddressTypeId).HasColumnName("AddressTypeID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // BusinessEntity
    internal class PersonBusinessEntityConfiguration : EntityTypeConfiguration<PersonBusinessEntity>
    {
        public PersonBusinessEntityConfiguration(string schema = "Person")
        {
            ToTable(schema + ".BusinessEntity");
            HasKey(x => x.BusinessEntityId);

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // BusinessEntityAddress
    internal class PersonBusinessEntityAddressConfiguration : EntityTypeConfiguration<PersonBusinessEntityAddress>
    {
        public PersonBusinessEntityAddressConfiguration(string schema = "Person")
        {
            ToTable(schema + ".BusinessEntityAddress");
            HasKey(x => new { x.BusinessEntityId, x.AddressId, x.AddressTypeId });

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.AddressId).HasColumnName("AddressID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.AddressTypeId).HasColumnName("AddressTypeID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.PersonBusinessEntity).WithMany(b => b.PersonBusinessEntityAddress).HasForeignKey(c => c.BusinessEntityId); // FK_BusinessEntityAddress_BusinessEntity_BusinessEntityID
            HasRequired(a => a.PersonAddress).WithMany(b => b.PersonBusinessEntityAddress).HasForeignKey(c => c.AddressId); // FK_BusinessEntityAddress_Address_AddressID
            HasRequired(a => a.PersonAddressType).WithMany(b => b.PersonBusinessEntityAddress).HasForeignKey(c => c.AddressTypeId); // FK_BusinessEntityAddress_AddressType_AddressTypeID
        }
    }

    // BusinessEntityContact
    internal class PersonBusinessEntityContactConfiguration : EntityTypeConfiguration<PersonBusinessEntityContact>
    {
        public PersonBusinessEntityContactConfiguration(string schema = "Person")
        {
            ToTable(schema + ".BusinessEntityContact");
            HasKey(x => new { x.BusinessEntityId, x.PersonId, x.ContactTypeId });

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.PersonId).HasColumnName("PersonID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ContactTypeId).HasColumnName("ContactTypeID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.PersonBusinessEntity).WithMany(b => b.PersonBusinessEntityContact).HasForeignKey(c => c.BusinessEntityId); // FK_BusinessEntityContact_BusinessEntity_BusinessEntityID
            HasRequired(a => a.PersonPerson).WithMany(b => b.PersonBusinessEntityContact).HasForeignKey(c => c.PersonId); // FK_BusinessEntityContact_Person_PersonID
            HasRequired(a => a.PersonContactType).WithMany(b => b.PersonBusinessEntityContact).HasForeignKey(c => c.ContactTypeId); // FK_BusinessEntityContact_ContactType_ContactTypeID
        }
    }

    // ContactType
    internal class PersonContactTypeConfiguration : EntityTypeConfiguration<PersonContactType>
    {
        public PersonContactTypeConfiguration(string schema = "Person")
        {
            ToTable(schema + ".ContactType");
            HasKey(x => x.ContactTypeId);

            Property(x => x.ContactTypeId).HasColumnName("ContactTypeID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // CountryRegion
    internal class PersonCountryRegionConfiguration : EntityTypeConfiguration<PersonCountryRegion>
    {
        public PersonCountryRegionConfiguration(string schema = "Person")
        {
            ToTable(schema + ".CountryRegion");
            HasKey(x => x.CountryRegionCode);

            Property(x => x.CountryRegionCode).HasColumnName("CountryRegionCode").IsRequired().HasMaxLength(3).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // EmailAddress
    internal class PersonEmailAddressConfiguration : EntityTypeConfiguration<PersonEmailAddress>
    {
        public PersonEmailAddressConfiguration(string schema = "Person")
        {
            ToTable(schema + ".EmailAddress");
            HasKey(x => new { x.BusinessEntityId, x.EmailAddressId });

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.EmailAddressId).HasColumnName("EmailAddressID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.EmailAddress).HasColumnName("EmailAddress").IsOptional().HasMaxLength(50);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.PersonPerson).WithMany(b => b.PersonEmailAddress).HasForeignKey(c => c.BusinessEntityId); // FK_EmailAddress_Person_BusinessEntityID
        }
    }

    // Password
    internal class PersonPasswordConfiguration : EntityTypeConfiguration<PersonPassword>
    {
        public PersonPasswordConfiguration(string schema = "Person")
        {
            ToTable(schema + ".Password");
            HasKey(x => x.BusinessEntityId);

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.PasswordHash).HasColumnName("PasswordHash").IsRequired().IsUnicode(false).HasMaxLength(128);
            Property(x => x.PasswordSalt).HasColumnName("PasswordSalt").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.PersonPerson).WithOptional(b => b.PersonPassword); // FK_Password_Person_BusinessEntityID
        }
    }

    // Person
    internal class PersonPersonConfiguration : EntityTypeConfiguration<PersonPerson>
    {
        public PersonPersonConfiguration(string schema = "Person")
        {
            ToTable(schema + ".Person");
            HasKey(x => x.BusinessEntityId);

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.PersonType).HasColumnName("PersonType").IsRequired().IsFixedLength().HasMaxLength(2);
            Property(x => x.NameStyle).HasColumnName("NameStyle").IsRequired();
            Property(x => x.Title).HasColumnName("Title").IsOptional().HasMaxLength(8);
            Property(x => x.FirstName).HasColumnName("FirstName").IsRequired().HasMaxLength(50);
            Property(x => x.MiddleName).HasColumnName("MiddleName").IsOptional().HasMaxLength(50);
            Property(x => x.LastName).HasColumnName("LastName").IsRequired().HasMaxLength(50);
            Property(x => x.Suffix).HasColumnName("Suffix").IsOptional().HasMaxLength(10);
            Property(x => x.EmailPromotion).HasColumnName("EmailPromotion").IsRequired();
            Property(x => x.AdditionalContactInfo).HasColumnName("AdditionalContactInfo").IsOptional();
            Property(x => x.Demographics).HasColumnName("Demographics").IsOptional();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.PersonBusinessEntity).WithOptional(b => b.PersonPerson); // FK_Person_BusinessEntity_BusinessEntityID
        }
    }

    // PersonPhone
    internal class PersonPersonPhoneConfiguration : EntityTypeConfiguration<PersonPersonPhone>
    {
        public PersonPersonPhoneConfiguration(string schema = "Person")
        {
            ToTable(schema + ".PersonPhone");
            HasKey(x => new { x.BusinessEntityId, x.PhoneNumber, x.PhoneNumberTypeId });

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.PhoneNumber).HasColumnName("PhoneNumber").IsRequired().HasMaxLength(25).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.PhoneNumberTypeId).HasColumnName("PhoneNumberTypeID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.PersonPerson).WithMany(b => b.PersonPersonPhone).HasForeignKey(c => c.BusinessEntityId); // FK_PersonPhone_Person_BusinessEntityID
            HasRequired(a => a.PersonPhoneNumberType).WithMany(b => b.PersonPersonPhone).HasForeignKey(c => c.PhoneNumberTypeId); // FK_PersonPhone_PhoneNumberType_PhoneNumberTypeID
        }
    }

    // PhoneNumberType
    internal class PersonPhoneNumberTypeConfiguration : EntityTypeConfiguration<PersonPhoneNumberType>
    {
        public PersonPhoneNumberTypeConfiguration(string schema = "Person")
        {
            ToTable(schema + ".PhoneNumberType");
            HasKey(x => x.PhoneNumberTypeId);

            Property(x => x.PhoneNumberTypeId).HasColumnName("PhoneNumberTypeID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // StateProvince
    internal class PersonStateProvinceConfiguration : EntityTypeConfiguration<PersonStateProvince>
    {
        public PersonStateProvinceConfiguration(string schema = "Person")
        {
            ToTable(schema + ".StateProvince");
            HasKey(x => x.StateProvinceId);

            Property(x => x.StateProvinceId).HasColumnName("StateProvinceID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.StateProvinceCode).HasColumnName("StateProvinceCode").IsRequired().IsFixedLength().HasMaxLength(3);
            Property(x => x.CountryRegionCode).HasColumnName("CountryRegionCode").IsRequired().HasMaxLength(3);
            Property(x => x.IsOnlyStateProvinceFlag).HasColumnName("IsOnlyStateProvinceFlag").IsRequired();
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.TerritoryId).HasColumnName("TerritoryID").IsRequired();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.PersonCountryRegion).WithMany(b => b.PersonStateProvince).HasForeignKey(c => c.CountryRegionCode); // FK_StateProvince_CountryRegion_CountryRegionCode
            HasRequired(a => a.SalesSalesTerritory).WithMany(b => b.PersonStateProvince).HasForeignKey(c => c.TerritoryId); // FK_StateProvince_SalesTerritory_TerritoryID
        }
    }

    // BillOfMaterials
    internal class ProductionBillOfMaterialsConfiguration : EntityTypeConfiguration<ProductionBillOfMaterials>
    {
        public ProductionBillOfMaterialsConfiguration(string schema = "Production")
        {
            ToTable(schema + ".BillOfMaterials");
            HasKey(x => x.BillOfMaterialsId);

            Property(x => x.BillOfMaterialsId).HasColumnName("BillOfMaterialsID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ProductAssemblyId).HasColumnName("ProductAssemblyID").IsOptional();
            Property(x => x.ComponentId).HasColumnName("ComponentID").IsRequired();
            Property(x => x.StartDate).HasColumnName("StartDate").IsRequired();
            Property(x => x.EndDate).HasColumnName("EndDate").IsOptional();
            Property(x => x.UnitMeasureCode).HasColumnName("UnitMeasureCode").IsRequired().IsFixedLength().HasMaxLength(3);
            Property(x => x.BomLevel).HasColumnName("BOMLevel").IsRequired();
            Property(x => x.PerAssemblyQty).HasColumnName("PerAssemblyQty").IsRequired().HasPrecision(8,2);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasOptional(a => a.ProductionProduct_ProductAssemblyId).WithMany(b => b.ProductionBillOfMaterials_ProductAssemblyId).HasForeignKey(c => c.ProductAssemblyId); // FK_BillOfMaterials_Product_ProductAssemblyID
            HasRequired(a => a.ProductionProduct_ComponentId).WithMany(b => b.ProductionBillOfMaterials_ComponentId).HasForeignKey(c => c.ComponentId); // FK_BillOfMaterials_Product_ComponentID
            HasRequired(a => a.ProductionUnitMeasure).WithMany(b => b.ProductionBillOfMaterials).HasForeignKey(c => c.UnitMeasureCode); // FK_BillOfMaterials_UnitMeasure_UnitMeasureCode
        }
    }

    // Culture
    internal class ProductionCultureConfiguration : EntityTypeConfiguration<ProductionCulture>
    {
        public ProductionCultureConfiguration(string schema = "Production")
        {
            ToTable(schema + ".Culture");
            HasKey(x => x.CultureId);

            Property(x => x.CultureId).HasColumnName("CultureID").IsRequired().IsFixedLength().HasMaxLength(6).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // Document
    internal class ProductionDocumentConfiguration : EntityTypeConfiguration<ProductionDocument>
    {
        public ProductionDocumentConfiguration(string schema = "Production")
        {
            ToTable(schema + ".Document");
            HasKey(x => x.DocumentNode);

            Property(x => x.DocumentNode).HasColumnName("DocumentNode").IsRequired();
            Property(x => x.DocumentLevel).HasColumnName("DocumentLevel").IsOptional().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.Title).HasColumnName("Title").IsRequired().HasMaxLength(50);
            Property(x => x.Owner).HasColumnName("Owner").IsRequired();
            Property(x => x.FolderFlag).HasColumnName("FolderFlag").IsRequired();
            Property(x => x.FileName).HasColumnName("FileName").IsRequired().HasMaxLength(400);
            Property(x => x.FileExtension).HasColumnName("FileExtension").IsRequired().HasMaxLength(8);
            Property(x => x.Revision).HasColumnName("Revision").IsRequired().IsFixedLength().HasMaxLength(5);
            Property(x => x.ChangeNumber).HasColumnName("ChangeNumber").IsRequired();
            Property(x => x.Status).HasColumnName("Status").IsRequired();
            Property(x => x.DocumentSummary).HasColumnName("DocumentSummary").IsOptional();
            Property(x => x.Document).HasColumnName("Document").IsOptional();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.HumanResourcesEmployee).WithMany(b => b.ProductionDocument).HasForeignKey(c => c.Owner); // FK_Document_Employee_Owner
        }
    }

    // Illustration
    internal class ProductionIllustrationConfiguration : EntityTypeConfiguration<ProductionIllustration>
    {
        public ProductionIllustrationConfiguration(string schema = "Production")
        {
            ToTable(schema + ".Illustration");
            HasKey(x => x.IllustrationId);

            Property(x => x.IllustrationId).HasColumnName("IllustrationID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Diagram).HasColumnName("Diagram").IsOptional();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // Location
    internal class ProductionLocationConfiguration : EntityTypeConfiguration<ProductionLocation>
    {
        public ProductionLocationConfiguration(string schema = "Production")
        {
            ToTable(schema + ".Location");
            HasKey(x => x.LocationId);

            Property(x => x.LocationId).HasColumnName("LocationID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.CostRate).HasColumnName("CostRate").IsRequired().HasPrecision(10,4);
            Property(x => x.Availability).HasColumnName("Availability").IsRequired().HasPrecision(8,2);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // Product
    internal class ProductionProductConfiguration : EntityTypeConfiguration<ProductionProduct>
    {
        public ProductionProductConfiguration(string schema = "Production")
        {
            ToTable(schema + ".Product");
            HasKey(x => x.ProductId);

            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.ProductNumber).HasColumnName("ProductNumber").IsRequired().HasMaxLength(25);
            Property(x => x.MakeFlag).HasColumnName("MakeFlag").IsRequired();
            Property(x => x.FinishedGoodsFlag).HasColumnName("FinishedGoodsFlag").IsRequired();
            Property(x => x.Color).HasColumnName("Color").IsOptional().HasMaxLength(15);
            Property(x => x.SafetyStockLevel).HasColumnName("SafetyStockLevel").IsRequired();
            Property(x => x.ReorderPoint).HasColumnName("ReorderPoint").IsRequired();
            Property(x => x.StandardCost).HasColumnName("StandardCost").IsRequired().HasPrecision(19,4);
            Property(x => x.ListPrice).HasColumnName("ListPrice").IsRequired().HasPrecision(19,4);
            Property(x => x.Size).HasColumnName("Size").IsOptional().HasMaxLength(5);
            Property(x => x.SizeUnitMeasureCode).HasColumnName("SizeUnitMeasureCode").IsOptional().IsFixedLength().HasMaxLength(3);
            Property(x => x.WeightUnitMeasureCode).HasColumnName("WeightUnitMeasureCode").IsOptional().IsFixedLength().HasMaxLength(3);
            Property(x => x.Weight).HasColumnName("Weight").IsOptional().HasPrecision(8,2);
            Property(x => x.DaysToManufacture).HasColumnName("DaysToManufacture").IsRequired();
            Property(x => x.ProductLine).HasColumnName("ProductLine").IsOptional().IsFixedLength().HasMaxLength(2);
            Property(x => x.Class).HasColumnName("Class").IsOptional().IsFixedLength().HasMaxLength(2);
            Property(x => x.Style).HasColumnName("Style").IsOptional().IsFixedLength().HasMaxLength(2);
            Property(x => x.ProductSubcategoryId).HasColumnName("ProductSubcategoryID").IsOptional();
            Property(x => x.ProductModelId).HasColumnName("ProductModelID").IsOptional();
            Property(x => x.SellStartDate).HasColumnName("SellStartDate").IsRequired();
            Property(x => x.SellEndDate).HasColumnName("SellEndDate").IsOptional();
            Property(x => x.DiscontinuedDate).HasColumnName("DiscontinuedDate").IsOptional();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasOptional(a => a.ProductionUnitMeasure_SizeUnitMeasureCode).WithMany(b => b.ProductionProduct_SizeUnitMeasureCode).HasForeignKey(c => c.SizeUnitMeasureCode); // FK_Product_UnitMeasure_SizeUnitMeasureCode
            HasOptional(a => a.ProductionUnitMeasure_WeightUnitMeasureCode).WithMany(b => b.ProductionProduct_WeightUnitMeasureCode).HasForeignKey(c => c.WeightUnitMeasureCode); // FK_Product_UnitMeasure_WeightUnitMeasureCode
            HasOptional(a => a.ProductionProductSubcategory).WithMany(b => b.ProductionProduct).HasForeignKey(c => c.ProductSubcategoryId); // FK_Product_ProductSubcategory_ProductSubcategoryID
            HasOptional(a => a.ProductionProductModel).WithMany(b => b.ProductionProduct).HasForeignKey(c => c.ProductModelId); // FK_Product_ProductModel_ProductModelID
        }
    }

    // ProductCategory
    internal class ProductionProductCategoryConfiguration : EntityTypeConfiguration<ProductionProductCategory>
    {
        public ProductionProductCategoryConfiguration(string schema = "Production")
        {
            ToTable(schema + ".ProductCategory");
            HasKey(x => x.ProductCategoryId);

            Property(x => x.ProductCategoryId).HasColumnName("ProductCategoryID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // ProductCostHistory
    internal class ProductionProductCostHistoryConfiguration : EntityTypeConfiguration<ProductionProductCostHistory>
    {
        public ProductionProductCostHistoryConfiguration(string schema = "Production")
        {
            ToTable(schema + ".ProductCostHistory");
            HasKey(x => new { x.ProductId, x.StartDate });

            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.StartDate).HasColumnName("StartDate").IsRequired();
            Property(x => x.EndDate).HasColumnName("EndDate").IsOptional();
            Property(x => x.StandardCost).HasColumnName("StandardCost").IsRequired().HasPrecision(19,4);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.ProductionProduct).WithMany(b => b.ProductionProductCostHistory).HasForeignKey(c => c.ProductId); // FK_ProductCostHistory_Product_ProductID
        }
    }

    // ProductDescription
    internal class ProductionProductDescriptionConfiguration : EntityTypeConfiguration<ProductionProductDescription>
    {
        public ProductionProductDescriptionConfiguration(string schema = "Production")
        {
            ToTable(schema + ".ProductDescription");
            HasKey(x => x.ProductDescriptionId);

            Property(x => x.ProductDescriptionId).HasColumnName("ProductDescriptionID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Description).HasColumnName("Description").IsRequired().HasMaxLength(400);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // ProductDocument
    internal class ProductionProductDocumentConfiguration : EntityTypeConfiguration<ProductionProductDocument>
    {
        public ProductionProductDocumentConfiguration(string schema = "Production")
        {
            ToTable(schema + ".ProductDocument");
            HasKey(x => new { x.ProductId, x.DocumentNode });

            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.DocumentNode).HasColumnName("DocumentNode").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.ProductionProduct).WithMany(b => b.ProductionProductDocument).HasForeignKey(c => c.ProductId); // FK_ProductDocument_Product_ProductID
            HasRequired(a => a.ProductionDocument).WithMany(b => b.ProductionProductDocument).HasForeignKey(c => c.DocumentNode); // FK_ProductDocument_Document_DocumentNode
        }
    }

    // ProductInventory
    internal class ProductionProductInventoryConfiguration : EntityTypeConfiguration<ProductionProductInventory>
    {
        public ProductionProductInventoryConfiguration(string schema = "Production")
        {
            ToTable(schema + ".ProductInventory");
            HasKey(x => new { x.ProductId, x.LocationId });

            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.LocationId).HasColumnName("LocationID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Shelf).HasColumnName("Shelf").IsRequired().HasMaxLength(10);
            Property(x => x.Bin).HasColumnName("Bin").IsRequired();
            Property(x => x.Quantity).HasColumnName("Quantity").IsRequired();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.ProductionProduct).WithMany(b => b.ProductionProductInventory).HasForeignKey(c => c.ProductId); // FK_ProductInventory_Product_ProductID
            HasRequired(a => a.ProductionLocation).WithMany(b => b.ProductionProductInventory).HasForeignKey(c => c.LocationId); // FK_ProductInventory_Location_LocationID
        }
    }

    // ProductListPriceHistory
    internal class ProductionProductListPriceHistoryConfiguration : EntityTypeConfiguration<ProductionProductListPriceHistory>
    {
        public ProductionProductListPriceHistoryConfiguration(string schema = "Production")
        {
            ToTable(schema + ".ProductListPriceHistory");
            HasKey(x => new { x.ProductId, x.StartDate });

            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.StartDate).HasColumnName("StartDate").IsRequired();
            Property(x => x.EndDate).HasColumnName("EndDate").IsOptional();
            Property(x => x.ListPrice).HasColumnName("ListPrice").IsRequired().HasPrecision(19,4);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.ProductionProduct).WithMany(b => b.ProductionProductListPriceHistory).HasForeignKey(c => c.ProductId); // FK_ProductListPriceHistory_Product_ProductID
        }
    }

    // ProductModel
    internal class ProductionProductModelConfiguration : EntityTypeConfiguration<ProductionProductModel>
    {
        public ProductionProductModelConfiguration(string schema = "Production")
        {
            ToTable(schema + ".ProductModel");
            HasKey(x => x.ProductModelId);

            Property(x => x.ProductModelId).HasColumnName("ProductModelID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.CatalogDescription).HasColumnName("CatalogDescription").IsOptional();
            Property(x => x.Instructions).HasColumnName("Instructions").IsOptional();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // ProductModelIllustration
    internal class ProductionProductModelIllustrationConfiguration : EntityTypeConfiguration<ProductionProductModelIllustration>
    {
        public ProductionProductModelIllustrationConfiguration(string schema = "Production")
        {
            ToTable(schema + ".ProductModelIllustration");
            HasKey(x => new { x.ProductModelId, x.IllustrationId });

            Property(x => x.ProductModelId).HasColumnName("ProductModelID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.IllustrationId).HasColumnName("IllustrationID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.ProductionProductModel).WithMany(b => b.ProductionProductModelIllustration).HasForeignKey(c => c.ProductModelId); // FK_ProductModelIllustration_ProductModel_ProductModelID
            HasRequired(a => a.ProductionIllustration).WithMany(b => b.ProductionProductModelIllustration).HasForeignKey(c => c.IllustrationId); // FK_ProductModelIllustration_Illustration_IllustrationID
        }
    }

    // ProductModelProductDescriptionCulture
    internal class ProductionProductModelProductDescriptionCultureConfiguration : EntityTypeConfiguration<ProductionProductModelProductDescriptionCulture>
    {
        public ProductionProductModelProductDescriptionCultureConfiguration(string schema = "Production")
        {
            ToTable(schema + ".ProductModelProductDescriptionCulture");
            HasKey(x => new { x.ProductModelId, x.ProductDescriptionId, x.CultureId });

            Property(x => x.ProductModelId).HasColumnName("ProductModelID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProductDescriptionId).HasColumnName("ProductDescriptionID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CultureId).HasColumnName("CultureID").IsRequired().IsFixedLength().HasMaxLength(6).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.ProductionProductModel).WithMany(b => b.ProductionProductModelProductDescriptionCulture).HasForeignKey(c => c.ProductModelId); // FK_ProductModelProductDescriptionCulture_ProductModel_ProductModelID
            HasRequired(a => a.ProductionProductDescription).WithMany(b => b.ProductionProductModelProductDescriptionCulture).HasForeignKey(c => c.ProductDescriptionId); // FK_ProductModelProductDescriptionCulture_ProductDescription_ProductDescriptionID
            HasRequired(a => a.ProductionCulture).WithMany(b => b.ProductionProductModelProductDescriptionCulture).HasForeignKey(c => c.CultureId); // FK_ProductModelProductDescriptionCulture_Culture_CultureID
        }
    }

    // ProductPhoto
    internal class ProductionProductPhotoConfiguration : EntityTypeConfiguration<ProductionProductPhoto>
    {
        public ProductionProductPhotoConfiguration(string schema = "Production")
        {
            ToTable(schema + ".ProductPhoto");
            HasKey(x => x.ProductPhotoId);

            Property(x => x.ProductPhotoId).HasColumnName("ProductPhotoID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ThumbNailPhoto).HasColumnName("ThumbNailPhoto").IsOptional();
            Property(x => x.ThumbnailPhotoFileName).HasColumnName("ThumbnailPhotoFileName").IsOptional().HasMaxLength(50);
            Property(x => x.LargePhoto).HasColumnName("LargePhoto").IsOptional();
            Property(x => x.LargePhotoFileName).HasColumnName("LargePhotoFileName").IsOptional().HasMaxLength(50);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // ProductProductPhoto
    internal class ProductionProductProductPhotoConfiguration : EntityTypeConfiguration<ProductionProductProductPhoto>
    {
        public ProductionProductProductPhotoConfiguration(string schema = "Production")
        {
            ToTable(schema + ".ProductProductPhoto");
            HasKey(x => new { x.ProductId, x.ProductPhotoId });

            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProductPhotoId).HasColumnName("ProductPhotoID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Primary).HasColumnName("Primary").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.ProductionProduct).WithMany(b => b.ProductionProductProductPhoto).HasForeignKey(c => c.ProductId); // FK_ProductProductPhoto_Product_ProductID
            HasRequired(a => a.ProductionProductPhoto).WithMany(b => b.ProductionProductProductPhoto).HasForeignKey(c => c.ProductPhotoId); // FK_ProductProductPhoto_ProductPhoto_ProductPhotoID
        }
    }

    // ProductReview
    internal class ProductionProductReviewConfiguration : EntityTypeConfiguration<ProductionProductReview>
    {
        public ProductionProductReviewConfiguration(string schema = "Production")
        {
            ToTable(schema + ".ProductReview");
            HasKey(x => x.ProductReviewId);

            Property(x => x.ProductReviewId).HasColumnName("ProductReviewID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired();
            Property(x => x.ReviewerName).HasColumnName("ReviewerName").IsRequired().HasMaxLength(50);
            Property(x => x.ReviewDate).HasColumnName("ReviewDate").IsRequired();
            Property(x => x.EmailAddress).HasColumnName("EmailAddress").IsRequired().HasMaxLength(50);
            Property(x => x.Rating).HasColumnName("Rating").IsRequired();
            Property(x => x.Comments).HasColumnName("Comments").IsOptional().HasMaxLength(3850);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.ProductionProduct).WithMany(b => b.ProductionProductReview).HasForeignKey(c => c.ProductId); // FK_ProductReview_Product_ProductID
        }
    }

    // ProductSubcategory
    internal class ProductionProductSubcategoryConfiguration : EntityTypeConfiguration<ProductionProductSubcategory>
    {
        public ProductionProductSubcategoryConfiguration(string schema = "Production")
        {
            ToTable(schema + ".ProductSubcategory");
            HasKey(x => x.ProductSubcategoryId);

            Property(x => x.ProductSubcategoryId).HasColumnName("ProductSubcategoryID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ProductCategoryId).HasColumnName("ProductCategoryID").IsRequired();
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.ProductionProductCategory).WithMany(b => b.ProductionProductSubcategory).HasForeignKey(c => c.ProductCategoryId); // FK_ProductSubcategory_ProductCategory_ProductCategoryID
        }
    }

    // ScrapReason
    internal class ProductionScrapReasonConfiguration : EntityTypeConfiguration<ProductionScrapReason>
    {
        public ProductionScrapReasonConfiguration(string schema = "Production")
        {
            ToTable(schema + ".ScrapReason");
            HasKey(x => x.ScrapReasonId);

            Property(x => x.ScrapReasonId).HasColumnName("ScrapReasonID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // TransactionHistory
    internal class ProductionTransactionHistoryConfiguration : EntityTypeConfiguration<ProductionTransactionHistory>
    {
        public ProductionTransactionHistoryConfiguration(string schema = "Production")
        {
            ToTable(schema + ".TransactionHistory");
            HasKey(x => x.TransactionId);

            Property(x => x.TransactionId).HasColumnName("TransactionID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired();
            Property(x => x.ReferenceOrderId).HasColumnName("ReferenceOrderID").IsRequired();
            Property(x => x.ReferenceOrderLineId).HasColumnName("ReferenceOrderLineID").IsRequired();
            Property(x => x.TransactionDate).HasColumnName("TransactionDate").IsRequired();
            Property(x => x.TransactionType).HasColumnName("TransactionType").IsRequired().IsFixedLength().HasMaxLength(1);
            Property(x => x.Quantity).HasColumnName("Quantity").IsRequired();
            Property(x => x.ActualCost).HasColumnName("ActualCost").IsRequired().HasPrecision(19,4);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.ProductionProduct).WithMany(b => b.ProductionTransactionHistory).HasForeignKey(c => c.ProductId); // FK_TransactionHistory_Product_ProductID
        }
    }

    // TransactionHistoryArchive
    internal class ProductionTransactionHistoryArchiveConfiguration : EntityTypeConfiguration<ProductionTransactionHistoryArchive>
    {
        public ProductionTransactionHistoryArchiveConfiguration(string schema = "Production")
        {
            ToTable(schema + ".TransactionHistoryArchive");
            HasKey(x => x.TransactionId);

            Property(x => x.TransactionId).HasColumnName("TransactionID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired();
            Property(x => x.ReferenceOrderId).HasColumnName("ReferenceOrderID").IsRequired();
            Property(x => x.ReferenceOrderLineId).HasColumnName("ReferenceOrderLineID").IsRequired();
            Property(x => x.TransactionDate).HasColumnName("TransactionDate").IsRequired();
            Property(x => x.TransactionType).HasColumnName("TransactionType").IsRequired().IsFixedLength().HasMaxLength(1);
            Property(x => x.Quantity).HasColumnName("Quantity").IsRequired();
            Property(x => x.ActualCost).HasColumnName("ActualCost").IsRequired().HasPrecision(19,4);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // UnitMeasure
    internal class ProductionUnitMeasureConfiguration : EntityTypeConfiguration<ProductionUnitMeasure>
    {
        public ProductionUnitMeasureConfiguration(string schema = "Production")
        {
            ToTable(schema + ".UnitMeasure");
            HasKey(x => x.UnitMeasureCode);

            Property(x => x.UnitMeasureCode).HasColumnName("UnitMeasureCode").IsRequired().IsFixedLength().HasMaxLength(3).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // WorkOrder
    internal class ProductionWorkOrderConfiguration : EntityTypeConfiguration<ProductionWorkOrder>
    {
        public ProductionWorkOrderConfiguration(string schema = "Production")
        {
            ToTable(schema + ".WorkOrder");
            HasKey(x => x.WorkOrderId);

            Property(x => x.WorkOrderId).HasColumnName("WorkOrderID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired();
            Property(x => x.OrderQty).HasColumnName("OrderQty").IsRequired();
            Property(x => x.StockedQty).HasColumnName("StockedQty").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.ScrappedQty).HasColumnName("ScrappedQty").IsRequired();
            Property(x => x.StartDate).HasColumnName("StartDate").IsRequired();
            Property(x => x.EndDate).HasColumnName("EndDate").IsOptional();
            Property(x => x.DueDate).HasColumnName("DueDate").IsRequired();
            Property(x => x.ScrapReasonId).HasColumnName("ScrapReasonID").IsOptional();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.ProductionProduct).WithMany(b => b.ProductionWorkOrder).HasForeignKey(c => c.ProductId); // FK_WorkOrder_Product_ProductID
            HasOptional(a => a.ProductionScrapReason).WithMany(b => b.ProductionWorkOrder).HasForeignKey(c => c.ScrapReasonId); // FK_WorkOrder_ScrapReason_ScrapReasonID
        }
    }

    // WorkOrderRouting
    internal class ProductionWorkOrderRoutingConfiguration : EntityTypeConfiguration<ProductionWorkOrderRouting>
    {
        public ProductionWorkOrderRoutingConfiguration(string schema = "Production")
        {
            ToTable(schema + ".WorkOrderRouting");
            HasKey(x => new { x.WorkOrderId, x.ProductId, x.OperationSequence });

            Property(x => x.WorkOrderId).HasColumnName("WorkOrderID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.OperationSequence).HasColumnName("OperationSequence").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.LocationId).HasColumnName("LocationID").IsRequired();
            Property(x => x.ScheduledStartDate).HasColumnName("ScheduledStartDate").IsRequired();
            Property(x => x.ScheduledEndDate).HasColumnName("ScheduledEndDate").IsRequired();
            Property(x => x.ActualStartDate).HasColumnName("ActualStartDate").IsOptional();
            Property(x => x.ActualEndDate).HasColumnName("ActualEndDate").IsOptional();
            Property(x => x.ActualResourceHrs).HasColumnName("ActualResourceHrs").IsOptional().HasPrecision(9,4);
            Property(x => x.PlannedCost).HasColumnName("PlannedCost").IsRequired().HasPrecision(19,4);
            Property(x => x.ActualCost).HasColumnName("ActualCost").IsOptional().HasPrecision(19,4);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.ProductionWorkOrder).WithMany(b => b.ProductionWorkOrderRouting).HasForeignKey(c => c.WorkOrderId); // FK_WorkOrderRouting_WorkOrder_WorkOrderID
            HasRequired(a => a.ProductionLocation).WithMany(b => b.ProductionWorkOrderRouting).HasForeignKey(c => c.LocationId); // FK_WorkOrderRouting_Location_LocationID
        }
    }

    // ProductVendor
    internal class PurchasingProductVendorConfiguration : EntityTypeConfiguration<PurchasingProductVendor>
    {
        public PurchasingProductVendorConfiguration(string schema = "Purchasing")
        {
            ToTable(schema + ".ProductVendor");
            HasKey(x => new { x.ProductId, x.BusinessEntityId });

            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.AverageLeadTime).HasColumnName("AverageLeadTime").IsRequired();
            Property(x => x.StandardPrice).HasColumnName("StandardPrice").IsRequired().HasPrecision(19,4);
            Property(x => x.LastReceiptCost).HasColumnName("LastReceiptCost").IsOptional().HasPrecision(19,4);
            Property(x => x.LastReceiptDate).HasColumnName("LastReceiptDate").IsOptional();
            Property(x => x.MinOrderQty).HasColumnName("MinOrderQty").IsRequired();
            Property(x => x.MaxOrderQty).HasColumnName("MaxOrderQty").IsRequired();
            Property(x => x.OnOrderQty).HasColumnName("OnOrderQty").IsOptional();
            Property(x => x.UnitMeasureCode).HasColumnName("UnitMeasureCode").IsRequired().IsFixedLength().HasMaxLength(3);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.ProductionProduct).WithMany(b => b.PurchasingProductVendor).HasForeignKey(c => c.ProductId); // FK_ProductVendor_Product_ProductID
            HasRequired(a => a.PurchasingVendor).WithMany(b => b.PurchasingProductVendor).HasForeignKey(c => c.BusinessEntityId); // FK_ProductVendor_Vendor_BusinessEntityID
            HasRequired(a => a.ProductionUnitMeasure).WithMany(b => b.PurchasingProductVendor).HasForeignKey(c => c.UnitMeasureCode); // FK_ProductVendor_UnitMeasure_UnitMeasureCode
        }
    }

    // PurchaseOrderDetail
    internal class PurchasingPurchaseOrderDetailConfiguration : EntityTypeConfiguration<PurchasingPurchaseOrderDetail>
    {
        public PurchasingPurchaseOrderDetailConfiguration(string schema = "Purchasing")
        {
            ToTable(schema + ".PurchaseOrderDetail");
            HasKey(x => new { x.PurchaseOrderId, x.PurchaseOrderDetailId });

            Property(x => x.PurchaseOrderId).HasColumnName("PurchaseOrderID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.PurchaseOrderDetailId).HasColumnName("PurchaseOrderDetailID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.DueDate).HasColumnName("DueDate").IsRequired();
            Property(x => x.OrderQty).HasColumnName("OrderQty").IsRequired();
            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired();
            Property(x => x.UnitPrice).HasColumnName("UnitPrice").IsRequired().HasPrecision(19,4);
            Property(x => x.LineTotal).HasColumnName("LineTotal").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.ReceivedQty).HasColumnName("ReceivedQty").IsRequired().HasPrecision(8,2);
            Property(x => x.RejectedQty).HasColumnName("RejectedQty").IsRequired().HasPrecision(8,2);
            Property(x => x.StockedQty).HasColumnName("StockedQty").IsRequired().HasPrecision(9,2).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.PurchasingPurchaseOrderHeader).WithMany(b => b.PurchasingPurchaseOrderDetail).HasForeignKey(c => c.PurchaseOrderId); // FK_PurchaseOrderDetail_PurchaseOrderHeader_PurchaseOrderID
            HasRequired(a => a.ProductionProduct).WithMany(b => b.PurchasingPurchaseOrderDetail).HasForeignKey(c => c.ProductId); // FK_PurchaseOrderDetail_Product_ProductID
        }
    }

    // PurchaseOrderHeader
    internal class PurchasingPurchaseOrderHeaderConfiguration : EntityTypeConfiguration<PurchasingPurchaseOrderHeader>
    {
        public PurchasingPurchaseOrderHeaderConfiguration(string schema = "Purchasing")
        {
            ToTable(schema + ".PurchaseOrderHeader");
            HasKey(x => x.PurchaseOrderId);

            Property(x => x.PurchaseOrderId).HasColumnName("PurchaseOrderID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.RevisionNumber).HasColumnName("RevisionNumber").IsRequired();
            Property(x => x.Status).HasColumnName("Status").IsRequired();
            Property(x => x.EmployeeId).HasColumnName("EmployeeID").IsRequired();
            Property(x => x.VendorId).HasColumnName("VendorID").IsRequired();
            Property(x => x.ShipMethodId).HasColumnName("ShipMethodID").IsRequired();
            Property(x => x.OrderDate).HasColumnName("OrderDate").IsRequired();
            Property(x => x.ShipDate).HasColumnName("ShipDate").IsOptional();
            Property(x => x.SubTotal).HasColumnName("SubTotal").IsRequired().HasPrecision(19,4);
            Property(x => x.TaxAmt).HasColumnName("TaxAmt").IsRequired().HasPrecision(19,4);
            Property(x => x.Freight).HasColumnName("Freight").IsRequired().HasPrecision(19,4);
            Property(x => x.TotalDue).HasColumnName("TotalDue").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.HumanResourcesEmployee).WithMany(b => b.PurchasingPurchaseOrderHeader).HasForeignKey(c => c.EmployeeId); // FK_PurchaseOrderHeader_Employee_EmployeeID
            HasRequired(a => a.PurchasingVendor).WithMany(b => b.PurchasingPurchaseOrderHeader).HasForeignKey(c => c.VendorId); // FK_PurchaseOrderHeader_Vendor_VendorID
            HasRequired(a => a.PurchasingShipMethod).WithMany(b => b.PurchasingPurchaseOrderHeader).HasForeignKey(c => c.ShipMethodId); // FK_PurchaseOrderHeader_ShipMethod_ShipMethodID
        }
    }

    // ShipMethod
    internal class PurchasingShipMethodConfiguration : EntityTypeConfiguration<PurchasingShipMethod>
    {
        public PurchasingShipMethodConfiguration(string schema = "Purchasing")
        {
            ToTable(schema + ".ShipMethod");
            HasKey(x => x.ShipMethodId);

            Property(x => x.ShipMethodId).HasColumnName("ShipMethodID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.ShipBase).HasColumnName("ShipBase").IsRequired().HasPrecision(19,4);
            Property(x => x.ShipRate).HasColumnName("ShipRate").IsRequired().HasPrecision(19,4);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // Vendor
    internal class PurchasingVendorConfiguration : EntityTypeConfiguration<PurchasingVendor>
    {
        public PurchasingVendorConfiguration(string schema = "Purchasing")
        {
            ToTable(schema + ".Vendor");
            HasKey(x => x.BusinessEntityId);

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.AccountNumber).HasColumnName("AccountNumber").IsRequired().HasMaxLength(15);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.CreditRating).HasColumnName("CreditRating").IsRequired();
            Property(x => x.PreferredVendorStatus).HasColumnName("PreferredVendorStatus").IsRequired();
            Property(x => x.ActiveFlag).HasColumnName("ActiveFlag").IsRequired();
            Property(x => x.PurchasingWebServiceUrl).HasColumnName("PurchasingWebServiceURL").IsOptional().HasMaxLength(1024);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.PersonBusinessEntity).WithOptional(b => b.PurchasingVendor); // FK_Vendor_BusinessEntity_BusinessEntityID
        }
    }

    // CountryRegionCurrency
    internal class SalesCountryRegionCurrencyConfiguration : EntityTypeConfiguration<SalesCountryRegionCurrency>
    {
        public SalesCountryRegionCurrencyConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".CountryRegionCurrency");
            HasKey(x => new { x.CountryRegionCode, x.CurrencyCode });

            Property(x => x.CountryRegionCode).HasColumnName("CountryRegionCode").IsRequired().HasMaxLength(3).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CurrencyCode).HasColumnName("CurrencyCode").IsRequired().IsFixedLength().HasMaxLength(3).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.PersonCountryRegion).WithMany(b => b.SalesCountryRegionCurrency).HasForeignKey(c => c.CountryRegionCode); // FK_CountryRegionCurrency_CountryRegion_CountryRegionCode
            HasRequired(a => a.SalesCurrency).WithMany(b => b.SalesCountryRegionCurrency).HasForeignKey(c => c.CurrencyCode); // FK_CountryRegionCurrency_Currency_CurrencyCode
        }
    }

    // CreditCard
    internal class SalesCreditCardConfiguration : EntityTypeConfiguration<SalesCreditCard>
    {
        public SalesCreditCardConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".CreditCard");
            HasKey(x => x.CreditCardId);

            Property(x => x.CreditCardId).HasColumnName("CreditCardID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CardType).HasColumnName("CardType").IsRequired().HasMaxLength(50);
            Property(x => x.CardNumber).HasColumnName("CardNumber").IsRequired().HasMaxLength(25);
            Property(x => x.ExpMonth).HasColumnName("ExpMonth").IsRequired();
            Property(x => x.ExpYear).HasColumnName("ExpYear").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // Currency
    internal class SalesCurrencyConfiguration : EntityTypeConfiguration<SalesCurrency>
    {
        public SalesCurrencyConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".Currency");
            HasKey(x => x.CurrencyCode);

            Property(x => x.CurrencyCode).HasColumnName("CurrencyCode").IsRequired().IsFixedLength().HasMaxLength(3).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // CurrencyRate
    internal class SalesCurrencyRateConfiguration : EntityTypeConfiguration<SalesCurrencyRate>
    {
        public SalesCurrencyRateConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".CurrencyRate");
            HasKey(x => x.CurrencyRateId);

            Property(x => x.CurrencyRateId).HasColumnName("CurrencyRateID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CurrencyRateDate).HasColumnName("CurrencyRateDate").IsRequired();
            Property(x => x.FromCurrencyCode).HasColumnName("FromCurrencyCode").IsRequired().IsFixedLength().HasMaxLength(3);
            Property(x => x.ToCurrencyCode).HasColumnName("ToCurrencyCode").IsRequired().IsFixedLength().HasMaxLength(3);
            Property(x => x.AverageRate).HasColumnName("AverageRate").IsRequired().HasPrecision(19,4);
            Property(x => x.EndOfDayRate).HasColumnName("EndOfDayRate").IsRequired().HasPrecision(19,4);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.SalesCurrency_FromCurrencyCode).WithMany(b => b.SalesCurrencyRate_FromCurrencyCode).HasForeignKey(c => c.FromCurrencyCode); // FK_CurrencyRate_Currency_FromCurrencyCode
            HasRequired(a => a.SalesCurrency_ToCurrencyCode).WithMany(b => b.SalesCurrencyRate_ToCurrencyCode).HasForeignKey(c => c.ToCurrencyCode); // FK_CurrencyRate_Currency_ToCurrencyCode
        }
    }

    // Customer
    internal class SalesCustomerConfiguration : EntityTypeConfiguration<SalesCustomer>
    {
        public SalesCustomerConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".Customer");
            HasKey(x => x.CustomerId);

            Property(x => x.CustomerId).HasColumnName("CustomerID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.PersonId).HasColumnName("PersonID").IsOptional();
            Property(x => x.StoreId).HasColumnName("StoreID").IsOptional();
            Property(x => x.TerritoryId).HasColumnName("TerritoryID").IsOptional();
            Property(x => x.AccountNumber).HasColumnName("AccountNumber").IsRequired().IsUnicode(false).HasMaxLength(10).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasOptional(a => a.PersonPerson).WithMany(b => b.SalesCustomer).HasForeignKey(c => c.PersonId); // FK_Customer_Person_PersonID
            HasOptional(a => a.SalesStore).WithMany(b => b.SalesCustomer).HasForeignKey(c => c.StoreId); // FK_Customer_Store_StoreID
            HasOptional(a => a.SalesSalesTerritory).WithMany(b => b.SalesCustomer).HasForeignKey(c => c.TerritoryId); // FK_Customer_SalesTerritory_TerritoryID
        }
    }

    // PersonCreditCard
    internal class SalesPersonCreditCardConfiguration : EntityTypeConfiguration<SalesPersonCreditCard>
    {
        public SalesPersonCreditCardConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".PersonCreditCard");
            HasKey(x => new { x.BusinessEntityId, x.CreditCardId });

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CreditCardId).HasColumnName("CreditCardID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.PersonPerson).WithMany(b => b.SalesPersonCreditCard).HasForeignKey(c => c.BusinessEntityId); // FK_PersonCreditCard_Person_BusinessEntityID
            HasRequired(a => a.SalesCreditCard).WithMany(b => b.SalesPersonCreditCard).HasForeignKey(c => c.CreditCardId); // FK_PersonCreditCard_CreditCard_CreditCardID
        }
    }

    // SalesOrderDetail
    internal class SalesSalesOrderDetailConfiguration : EntityTypeConfiguration<SalesSalesOrderDetail>
    {
        public SalesSalesOrderDetailConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".SalesOrderDetail");
            HasKey(x => new { x.SalesOrderId, x.SalesOrderDetailId });

            Property(x => x.SalesOrderId).HasColumnName("SalesOrderID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.SalesOrderDetailId).HasColumnName("SalesOrderDetailID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CarrierTrackingNumber).HasColumnName("CarrierTrackingNumber").IsOptional().HasMaxLength(25);
            Property(x => x.OrderQty).HasColumnName("OrderQty").IsRequired();
            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired();
            Property(x => x.SpecialOfferId).HasColumnName("SpecialOfferID").IsRequired();
            Property(x => x.UnitPrice).HasColumnName("UnitPrice").IsRequired().HasPrecision(19,4);
            Property(x => x.UnitPriceDiscount).HasColumnName("UnitPriceDiscount").IsRequired().HasPrecision(19,4);
            Property(x => x.LineTotal).HasColumnName("LineTotal").IsRequired().HasPrecision(38,6).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.SalesSalesOrderHeader).WithMany(b => b.SalesSalesOrderDetail).HasForeignKey(c => c.SalesOrderId); // FK_SalesOrderDetail_SalesOrderHeader_SalesOrderID
            HasRequired(a => a.SalesSpecialOfferProduct).WithMany(b => b.SalesSalesOrderDetail).HasForeignKey(c => new { c.ProductId, c.SpecialOfferId }); // FK_SalesOrderDetail_SpecialOfferProduct_SpecialOfferIDProductID
        }
    }

    // SalesOrderHeader
    internal class SalesSalesOrderHeaderConfiguration : EntityTypeConfiguration<SalesSalesOrderHeader>
    {
        public SalesSalesOrderHeaderConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".SalesOrderHeader");
            HasKey(x => x.SalesOrderId);

            Property(x => x.SalesOrderId).HasColumnName("SalesOrderID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.RevisionNumber).HasColumnName("RevisionNumber").IsRequired();
            Property(x => x.OrderDate).HasColumnName("OrderDate").IsRequired();
            Property(x => x.DueDate).HasColumnName("DueDate").IsRequired();
            Property(x => x.ShipDate).HasColumnName("ShipDate").IsOptional();
            Property(x => x.Status).HasColumnName("Status").IsRequired();
            Property(x => x.OnlineOrderFlag).HasColumnName("OnlineOrderFlag").IsRequired();
            Property(x => x.SalesOrderNumber).HasColumnName("SalesOrderNumber").IsRequired().HasMaxLength(25).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.PurchaseOrderNumber).HasColumnName("PurchaseOrderNumber").IsOptional().HasMaxLength(25);
            Property(x => x.AccountNumber).HasColumnName("AccountNumber").IsOptional().HasMaxLength(15);
            Property(x => x.CustomerId).HasColumnName("CustomerID").IsRequired();
            Property(x => x.SalesPersonId).HasColumnName("SalesPersonID").IsOptional();
            Property(x => x.TerritoryId).HasColumnName("TerritoryID").IsOptional();
            Property(x => x.BillToAddressId).HasColumnName("BillToAddressID").IsRequired();
            Property(x => x.ShipToAddressId).HasColumnName("ShipToAddressID").IsRequired();
            Property(x => x.ShipMethodId).HasColumnName("ShipMethodID").IsRequired();
            Property(x => x.CreditCardId).HasColumnName("CreditCardID").IsOptional();
            Property(x => x.CreditCardApprovalCode).HasColumnName("CreditCardApprovalCode").IsOptional().IsUnicode(false).HasMaxLength(15);
            Property(x => x.CurrencyRateId).HasColumnName("CurrencyRateID").IsOptional();
            Property(x => x.SubTotal).HasColumnName("SubTotal").IsRequired().HasPrecision(19,4);
            Property(x => x.TaxAmt).HasColumnName("TaxAmt").IsRequired().HasPrecision(19,4);
            Property(x => x.Freight).HasColumnName("Freight").IsRequired().HasPrecision(19,4);
            Property(x => x.TotalDue).HasColumnName("TotalDue").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.Comment).HasColumnName("Comment").IsOptional().HasMaxLength(128);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.SalesCustomer).WithMany(b => b.SalesSalesOrderHeader).HasForeignKey(c => c.CustomerId); // FK_SalesOrderHeader_Customer_CustomerID
            HasOptional(a => a.SalesSalesPerson).WithMany(b => b.SalesSalesOrderHeader).HasForeignKey(c => c.SalesPersonId); // FK_SalesOrderHeader_SalesPerson_SalesPersonID
            HasOptional(a => a.SalesSalesTerritory).WithMany(b => b.SalesSalesOrderHeader).HasForeignKey(c => c.TerritoryId); // FK_SalesOrderHeader_SalesTerritory_TerritoryID
            HasRequired(a => a.PersonAddress_BillToAddressId).WithMany(b => b.SalesSalesOrderHeader_BillToAddressId).HasForeignKey(c => c.BillToAddressId); // FK_SalesOrderHeader_Address_BillToAddressID
            HasRequired(a => a.PersonAddress_ShipToAddressId).WithMany(b => b.SalesSalesOrderHeader_ShipToAddressId).HasForeignKey(c => c.ShipToAddressId); // FK_SalesOrderHeader_Address_ShipToAddressID
            HasRequired(a => a.PurchasingShipMethod).WithMany(b => b.SalesSalesOrderHeader).HasForeignKey(c => c.ShipMethodId); // FK_SalesOrderHeader_ShipMethod_ShipMethodID
            HasOptional(a => a.SalesCreditCard).WithMany(b => b.SalesSalesOrderHeader).HasForeignKey(c => c.CreditCardId); // FK_SalesOrderHeader_CreditCard_CreditCardID
            HasOptional(a => a.SalesCurrencyRate).WithMany(b => b.SalesSalesOrderHeader).HasForeignKey(c => c.CurrencyRateId); // FK_SalesOrderHeader_CurrencyRate_CurrencyRateID
        }
    }

    // SalesOrderHeaderSalesReason
    internal class SalesSalesOrderHeaderSalesReasonConfiguration : EntityTypeConfiguration<SalesSalesOrderHeaderSalesReason>
    {
        public SalesSalesOrderHeaderSalesReasonConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".SalesOrderHeaderSalesReason");
            HasKey(x => new { x.SalesOrderId, x.SalesReasonId });

            Property(x => x.SalesOrderId).HasColumnName("SalesOrderID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.SalesReasonId).HasColumnName("SalesReasonID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.SalesSalesOrderHeader).WithMany(b => b.SalesSalesOrderHeaderSalesReason).HasForeignKey(c => c.SalesOrderId); // FK_SalesOrderHeaderSalesReason_SalesOrderHeader_SalesOrderID
            HasRequired(a => a.SalesSalesReason).WithMany(b => b.SalesSalesOrderHeaderSalesReason).HasForeignKey(c => c.SalesReasonId); // FK_SalesOrderHeaderSalesReason_SalesReason_SalesReasonID
        }
    }

    // SalesPerson
    internal class SalesSalesPersonConfiguration : EntityTypeConfiguration<SalesSalesPerson>
    {
        public SalesSalesPersonConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".SalesPerson");
            HasKey(x => x.BusinessEntityId);

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.TerritoryId).HasColumnName("TerritoryID").IsOptional();
            Property(x => x.SalesQuota).HasColumnName("SalesQuota").IsOptional().HasPrecision(19,4);
            Property(x => x.Bonus).HasColumnName("Bonus").IsRequired().HasPrecision(19,4);
            Property(x => x.CommissionPct).HasColumnName("CommissionPct").IsRequired().HasPrecision(10,4);
            Property(x => x.SalesYtd).HasColumnName("SalesYTD").IsRequired().HasPrecision(19,4);
            Property(x => x.SalesLastYear).HasColumnName("SalesLastYear").IsRequired().HasPrecision(19,4);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.HumanResourcesEmployee).WithOptional(b => b.SalesSalesPerson); // FK_SalesPerson_Employee_BusinessEntityID
            HasOptional(a => a.SalesSalesTerritory).WithMany(b => b.SalesSalesPerson).HasForeignKey(c => c.TerritoryId); // FK_SalesPerson_SalesTerritory_TerritoryID
        }
    }

    // SalesPersonQuotaHistory
    internal class SalesSalesPersonQuotaHistoryConfiguration : EntityTypeConfiguration<SalesSalesPersonQuotaHistory>
    {
        public SalesSalesPersonQuotaHistoryConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".SalesPersonQuotaHistory");
            HasKey(x => new { x.BusinessEntityId, x.QuotaDate });

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.QuotaDate).HasColumnName("QuotaDate").IsRequired();
            Property(x => x.SalesQuota).HasColumnName("SalesQuota").IsRequired().HasPrecision(19,4);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.SalesSalesPerson).WithMany(b => b.SalesSalesPersonQuotaHistory).HasForeignKey(c => c.BusinessEntityId); // FK_SalesPersonQuotaHistory_SalesPerson_BusinessEntityID
        }
    }

    // SalesReason
    internal class SalesSalesReasonConfiguration : EntityTypeConfiguration<SalesSalesReason>
    {
        public SalesSalesReasonConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".SalesReason");
            HasKey(x => x.SalesReasonId);

            Property(x => x.SalesReasonId).HasColumnName("SalesReasonID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.ReasonType).HasColumnName("ReasonType").IsRequired().HasMaxLength(50);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // SalesTaxRate
    internal class SalesSalesTaxRateConfiguration : EntityTypeConfiguration<SalesSalesTaxRate>
    {
        public SalesSalesTaxRateConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".SalesTaxRate");
            HasKey(x => x.SalesTaxRateId);

            Property(x => x.SalesTaxRateId).HasColumnName("SalesTaxRateID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.StateProvinceId).HasColumnName("StateProvinceID").IsRequired();
            Property(x => x.TaxType).HasColumnName("TaxType").IsRequired();
            Property(x => x.TaxRate).HasColumnName("TaxRate").IsRequired().HasPrecision(10,4);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.PersonStateProvince).WithMany(b => b.SalesSalesTaxRate).HasForeignKey(c => c.StateProvinceId); // FK_SalesTaxRate_StateProvince_StateProvinceID
        }
    }

    // SalesTerritory
    internal class SalesSalesTerritoryConfiguration : EntityTypeConfiguration<SalesSalesTerritory>
    {
        public SalesSalesTerritoryConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".SalesTerritory");
            HasKey(x => x.TerritoryId);

            Property(x => x.TerritoryId).HasColumnName("TerritoryID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.CountryRegionCode).HasColumnName("CountryRegionCode").IsRequired().HasMaxLength(3);
            Property(x => x.Group).HasColumnName("Group").IsRequired().HasMaxLength(50);
            Property(x => x.SalesYtd).HasColumnName("SalesYTD").IsRequired().HasPrecision(19,4);
            Property(x => x.SalesLastYear).HasColumnName("SalesLastYear").IsRequired().HasPrecision(19,4);
            Property(x => x.CostYtd).HasColumnName("CostYTD").IsRequired().HasPrecision(19,4);
            Property(x => x.CostLastYear).HasColumnName("CostLastYear").IsRequired().HasPrecision(19,4);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.PersonCountryRegion).WithMany(b => b.SalesSalesTerritory).HasForeignKey(c => c.CountryRegionCode); // FK_SalesTerritory_CountryRegion_CountryRegionCode
        }
    }

    // SalesTerritoryHistory
    internal class SalesSalesTerritoryHistoryConfiguration : EntityTypeConfiguration<SalesSalesTerritoryHistory>
    {
        public SalesSalesTerritoryHistoryConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".SalesTerritoryHistory");
            HasKey(x => new { x.BusinessEntityId, x.TerritoryId, x.StartDate });

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.TerritoryId).HasColumnName("TerritoryID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.StartDate).HasColumnName("StartDate").IsRequired();
            Property(x => x.EndDate).HasColumnName("EndDate").IsOptional();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.SalesSalesPerson).WithMany(b => b.SalesSalesTerritoryHistory).HasForeignKey(c => c.BusinessEntityId); // FK_SalesTerritoryHistory_SalesPerson_BusinessEntityID
            HasRequired(a => a.SalesSalesTerritory).WithMany(b => b.SalesSalesTerritoryHistory).HasForeignKey(c => c.TerritoryId); // FK_SalesTerritoryHistory_SalesTerritory_TerritoryID
        }
    }

    // ShoppingCartItem
    internal class SalesShoppingCartItemConfiguration : EntityTypeConfiguration<SalesShoppingCartItem>
    {
        public SalesShoppingCartItemConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".ShoppingCartItem");
            HasKey(x => x.ShoppingCartItemId);

            Property(x => x.ShoppingCartItemId).HasColumnName("ShoppingCartItemID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ShoppingCartId).HasColumnName("ShoppingCartID").IsRequired().HasMaxLength(50);
            Property(x => x.Quantity).HasColumnName("Quantity").IsRequired();
            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired();
            Property(x => x.DateCreated).HasColumnName("DateCreated").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.ProductionProduct).WithMany(b => b.SalesShoppingCartItem).HasForeignKey(c => c.ProductId); // FK_ShoppingCartItem_Product_ProductID
        }
    }

    // SpecialOffer
    internal class SalesSpecialOfferConfiguration : EntityTypeConfiguration<SalesSpecialOffer>
    {
        public SalesSpecialOfferConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".SpecialOffer");
            HasKey(x => x.SpecialOfferId);

            Property(x => x.SpecialOfferId).HasColumnName("SpecialOfferID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Description).HasColumnName("Description").IsRequired().HasMaxLength(255);
            Property(x => x.DiscountPct).HasColumnName("DiscountPct").IsRequired().HasPrecision(10,4);
            Property(x => x.Type).HasColumnName("Type").IsRequired().HasMaxLength(50);
            Property(x => x.Category).HasColumnName("Category").IsRequired().HasMaxLength(50);
            Property(x => x.StartDate).HasColumnName("StartDate").IsRequired();
            Property(x => x.EndDate).HasColumnName("EndDate").IsRequired();
            Property(x => x.MinQty).HasColumnName("MinQty").IsRequired();
            Property(x => x.MaxQty).HasColumnName("MaxQty").IsOptional();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }

    // SpecialOfferProduct
    internal class SalesSpecialOfferProductConfiguration : EntityTypeConfiguration<SalesSpecialOfferProduct>
    {
        public SalesSpecialOfferProductConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".SpecialOfferProduct");
            HasKey(x => new { x.SpecialOfferId, x.ProductId });

            Property(x => x.SpecialOfferId).HasColumnName("SpecialOfferID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.SalesSpecialOffer).WithMany(b => b.SalesSpecialOfferProduct).HasForeignKey(c => c.SpecialOfferId); // FK_SpecialOfferProduct_SpecialOffer_SpecialOfferID
            HasRequired(a => a.ProductionProduct).WithMany(b => b.SalesSpecialOfferProduct).HasForeignKey(c => c.ProductId); // FK_SpecialOfferProduct_Product_ProductID
        }
    }

    // Store
    internal class SalesStoreConfiguration : EntityTypeConfiguration<SalesStore>
    {
        public SalesStoreConfiguration(string schema = "Sales")
        {
            ToTable(schema + ".Store");
            HasKey(x => x.BusinessEntityId);

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.SalesPersonId).HasColumnName("SalesPersonID").IsOptional();
            Property(x => x.Demographics).HasColumnName("Demographics").IsOptional();
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.PersonBusinessEntity).WithOptional(b => b.SalesStore); // FK_Store_BusinessEntity_BusinessEntityID
            HasOptional(a => a.SalesSalesPerson).WithMany(b => b.SalesStore).HasForeignKey(c => c.SalesPersonId); // FK_Store_SalesPerson_SalesPersonID
        }
    }

}

