using System.Data.Entity;

namespace Application.Models
{
    public class CammContext : DbContext
    {
        public DbSet<BOMs> BOM { get; set; }
        public DbSet<Configurations> Configuration { get; set; }
        public DbSet<Connectors> Connector { get; set; }
        public DbSet<ConnectorAdaptors> ConnectorAdaptor { get; set; }
        public DbSet<ConnectorDocuments> ConnectorDocument { get; set; }
        public DbSet<ConnectorTools> ConnectorTool { get; set; }
        public DbSet<Contacts> Contact { get; set; }
        public DbSet<ContactDocuments> ContactDocument { get; set; }
        public DbSet<ContactTools> ContactTool { get; set; }
        public DbSet<Documents> Document { get; set; }
        public DbSet<DocumentTypes> DocumentType { get; set; }
        public DbSet<Employees> Employee { get; set; }
        public DbSet<Files> File { get; set; }
        public DbSet<Items> Item { get; set; }
        public DbSet<ItemDocuments> ItemDocument { get; set; }
        public DbSet<PriceBreakQuantityStandards> PriceBreakQuantityStandard { get; set; }
        public DbSet<Proposals> Proposal { get; set; }
        public DbSet<ProposalPrices> ProposalPrice { get; set; }
        public DbSet<PulledPrices> PulledPrice { get; set; }
        public DbSet<PurchaseRequests> PurchaseRequest { get; set; }
        public DbSet<RF_CableTests> RF_CableTest { get; set; }
        public DbSet<RF_Requirements> RF_Requirement { get; set; }
        public DbSet<Scraps> Scrap { get; set; }
        public DbSet<TestCables> TestCable { get; set; }
        public DbSet<TimeEntrys> TimeEntry { get; set; }
        public DbSet<Tools> Tool { get; set; }
        public DbSet<ToolDocuments> ToolDocument { get; set; }
        public DbSet<Vendors> Vendor { get; set; }
        public DbSet<VendorQuotes> VendorQuote { get; set; }
        public DbSet<VendorQuoteDetails> VendorQuoteDetail { get; set; }
        public DbSet<VNA_States> VNA_State { get; set; }
        public DbSet<Wires> Wire { get; set; }
        public DbSet<WorkOrders> WorkOrder { get; set; }
        public DbSet<WorkOrderStatuss> WorkOrderStatus { get; set; }
    }

}
