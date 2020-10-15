using MyWeb.Common;
using MyWeb.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace MyWeb.Models
{
    
    /// <summary>
    /// Shippers class
    /// </summary>
    [MetadataType(typeof(ShippersMD))]
    public partial class Shippers
    {
    
    	/// <summary>
    	/// Shippers Metadata class
    	/// </summary>
    	public class ShippersMD
    	{
    		    
    		/// <summary>
    		/// Shipper ID
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ShipperID", typeof(NorthWindResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public int ShipperID { get; set; }
    
    		    
    		/// <summary>
    		/// Company Name
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("CompanyName", typeof(NorthWindResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(NorthWindResource))]
            [MaxLength(40, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public string CompanyName { get; set; }
    
    		    
    		/// <summary>
    		/// Phone
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("Phone", typeof(NorthWindResource))]
            [MaxLength(24, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public string Phone { get; set; }
    
    		    
    	}
    }
    
}
