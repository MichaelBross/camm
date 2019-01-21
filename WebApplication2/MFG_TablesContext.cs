using System.Data.Entity;

namespace Application.Models
{
    public class MFG_TablesContext : DbContext
    {
        public DbSet<WorkOrder> WorkOrders { get; set; }
        public DbSet<AmertronDrawingDocuments> AmertronDrawingDocuments { get; set; }
        public DbSet<AmertronDrawings> AmertronDrawings { get; set; }
        public DbSet<ApprovedMfgs> ApprovedMfgs { get; set; }
        public DbSet<Assemblies> Assemblies { get; set; }
        public DbSet<AssemblyDocuments> AssemblyDocuments { get; set; }
        public DbSet<AssemblyLaborEstimates> AssemblyLaborEstimates { get; set; }
        public DbSet<AssemblyOperations> AssemblyOperations { get; set; }
        public DbSet<AssemblyQuoteItems> AssemblyQuoteItems { get; set; }
        public DbSet<AssemblyQuotes> AssemblyQuotes { get; set; }
        public DbSet<AssemblyTypes> AssemblyTypes { get; set; }
        public DbSet<CodeFragments> CodeFragments { get; set; }
        public DbSet<Configurations> Configurations { get; set; }
        public DbSet<ConnectorAdaptors> ConnectorAdaptors { get; set; }
        public DbSet<ConnectorContacts> ConnectorContacts { get; set; }
        public DbSet<ConnectorDocuments> ConnectorDocuments { get; set; }
        public DbSet<Connectors> Connectors { get; set; }
        public DbSet<ConnectorTools> ConnectorTools { get; set; }
        public DbSet<ContactDocuments> ContactDocuments { get; set; }
        public DbSet<Contacts> Contacts { get; set; }
        public DbSet<ContactTools> ContactTools { get; set; }
        public DbSet<DBATableNames> DBATableNames { get; set; }
        public DbSet<DBA_BOM_Copy> DBA_BOM_Copy { get; set; }
        public DbSet<Documents> Documents { get; set; }
        public DbSet<DocumentTypes> DocumentTypes { get; set; }
        public DbSet<EmployeeTable> EmployeeTable { get; set; }
        public DbSet<Files> Files { get; set; }
        public DbSet<ItemDocuments> ItemDocuments { get; set; }
        public DbSet<ItemsCopy> ItemsCopy { get; set; }
        public DbSet<MFG_TableNames> MFG_TableNames { get; set; }
        public DbSet<OperationDocuments> OperationDocuments { get; set; }
        public DbSet<OperationItems> OperationItems { get; set; }
        public DbSet<Operations> Operations { get; set; }
        public DbSet<PriceBreakQuantityStandards> PriceBreakQuantityStandards { get; set; }
        public DbSet<ProductionLog> ProductionLog { get; set; }
        public DbSet<ProposalPrices> ProposalPrices { get; set; }
        public DbSet<Proposals> Proposals { get; set; }
        public DbSet<PTOtable> PTOtable { get; set; }
        public DbSet<PulledPrices> PulledPrices { get; set; }
        public DbSet<purchase_requests> purchase_requests { get; set; }
        public DbSet<rf_cable_tests> rf_cable_tests { get; set; }
        public DbSet<rf_requirements> rf_requirements { get; set; }
        public DbSet<RoutingOperations> RoutingOperations { get; set; }
        public DbSet<Routings> Routings { get; set; }
        public DbSet<scrap_log> scrap_log { get; set; }
        public DbSet<ServerFiles> ServerFiles { get; set; }
        public DbSet<TableToTableDataTransferWiring> TableToTableDataTransferWiring { get; set; }
        public DbSet<test_cable_log> test_cable_log { get; set; }
        public DbSet<time_log> time_log { get; set; }
        public DbSet<ToolDocuments> ToolDocuments { get; set; }
        public DbSet<Tools> Tools { get; set; }
        public DbSet<Traveler> Traveler { get; set; }
        public DbSet<TravelerOperation> TravelerOperation { get; set; }
        public DbSet<TravelerOpEvent> TravelerOpEvent { get; set; }
        public DbSet<VendorQuoteDetails> VendorQuoteDetails { get; set; }
        public DbSet<VendorQuotes> VendorQuotes { get; set; }
        public DbSet<Vendors> Vendors { get; set; }
        public DbSet<vna_states> vna_states { get; set; }
        public DbSet<Wires> Wires { get; set; }
        public DbSet<WorkOrdersCopy> WorkOrdersCopy { get; set; }
    }

}
