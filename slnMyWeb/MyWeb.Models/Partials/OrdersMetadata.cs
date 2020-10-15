using MyWeb.Common;
using MyWeb.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace MyWeb.Models
{
    
    /// <summary>
    /// Orders class
    /// </summary>
    [MetadataType(typeof(OrdersMD))]
    public partial class Orders
    {
    
    	/// <summary>
    	/// Orders Metadata class
    	/// </summary>
    	public class OrdersMD
    	{
    		    
    		/// <summary>
    		/// Order ID
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("OrderID", typeof(NorthWindResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public int OrderID { get; set; }
    
    		    
    		/// <summary>
    		/// Customer ID
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("CustomerID", typeof(NorthWindResource))]
            [MaxLength(5, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public string CustomerID { get; set; }
    
    		    
    		/// <summary>
    		/// Employee ID
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("EmployeeID", typeof(NorthWindResource))]
    		public Nullable<int> EmployeeID { get; set; }
    
    		    
    		/// <summary>
    		/// Order Date
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("OrderDate", typeof(NorthWindResource))]
    		public Nullable<System.DateTime> OrderDate { get; set; }
    
    		    
    		/// <summary>
    		/// Required Date
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("RequiredDate", typeof(NorthWindResource))]
    		public Nullable<System.DateTime> RequiredDate { get; set; }
    
    		    
    		/// <summary>
    		/// Shipped Date
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ShippedDate", typeof(NorthWindResource))]
    		public Nullable<System.DateTime> ShippedDate { get; set; }
    
    		    
    		/// <summary>
    		/// Ship Via
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ShipVia", typeof(NorthWindResource))]
    		public Nullable<int> ShipVia { get; set; }
    
    		    
    		/// <summary>
    		/// Freight
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("Freight", typeof(NorthWindResource))]
    		public Nullable<decimal> Freight { get; set; }
    
    		    
    		/// <summary>
    		/// Ship Name
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ShipName", typeof(NorthWindResource))]
            [MaxLength(40, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public string ShipName { get; set; }
    
    		    
    		/// <summary>
    		/// Ship Address
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ShipAddress", typeof(NorthWindResource))]
            [MaxLength(60, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public string ShipAddress { get; set; }
    
    		    
    		/// <summary>
    		/// Ship City
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ShipCity", typeof(NorthWindResource))]
            [MaxLength(15, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public string ShipCity { get; set; }
    
    		    
    		/// <summary>
    		/// Ship Region
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ShipRegion", typeof(NorthWindResource))]
            [MaxLength(15, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public string ShipRegion { get; set; }
    
    		    
    		/// <summary>
    		/// Ship Postal Code
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ShipPostalCode", typeof(NorthWindResource))]
            [MaxLength(10, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public string ShipPostalCode { get; set; }
    
    		    
    		/// <summary>
    		/// Ship Country
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ShipCountry", typeof(NorthWindResource))]
            [MaxLength(15, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public string ShipCountry { get; set; }
    
    		    
    	}
    }
    
}
