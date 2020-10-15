using MyWeb.Common;
using MyWeb.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace MyWeb.Models
{
    
    /// <summary>
    /// Customers class
    /// </summary>
    [MetadataType(typeof(CustomersMD))]
    public partial class Customers
    {
    
    	/// <summary>
    	/// Customers Metadata class
    	/// </summary>
    	public class CustomersMD
    	{
    		    
    		/// <summary>
    		/// Customer ID
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("CustomerID", typeof(NorthWindResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(NorthWindResource))]
            [MaxLength(5, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public string CustomerID { get; set; }
    
    		    
    		/// <summary>
    		/// Company Name
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("CompanyName", typeof(NorthWindResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(NorthWindResource))]
            [MaxLength(40, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public string CompanyName { get; set; }
    
    		    
    		/// <summary>
    		/// Contact Name
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ContactName", typeof(NorthWindResource))]
            [MaxLength(30, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public string ContactName { get; set; }
    
    		    
    		/// <summary>
    		/// Contact Title
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ContactTitle", typeof(NorthWindResource))]
            [MaxLength(30, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public string ContactTitle { get; set; }
    
    		    
    		/// <summary>
    		/// Address
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("Address", typeof(NorthWindResource))]
            [MaxLength(60, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public string Address { get; set; }
    
    		    
    		/// <summary>
    		/// City
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("City", typeof(NorthWindResource))]
            [MaxLength(15, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public string City { get; set; }
    
    		    
    		/// <summary>
    		/// Region
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("Region", typeof(NorthWindResource))]
            [MaxLength(15, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public string Region { get; set; }
    
    		    
    		/// <summary>
    		/// Postal Code
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("PostalCode", typeof(NorthWindResource))]
            [MaxLength(10, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public string PostalCode { get; set; }
    
    		    
    		/// <summary>
    		/// Country
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("Country", typeof(NorthWindResource))]
            [MaxLength(15, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public string Country { get; set; }
    
    		    
    		/// <summary>
    		/// Phone
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("Phone", typeof(NorthWindResource))]
            [MaxLength(24, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public string Phone { get; set; }
    
    		    
    		/// <summary>
    		/// Fax
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("Fax", typeof(NorthWindResource))]
            [MaxLength(24, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public string Fax { get; set; }
    
    		    
    	}
    }
    
}
