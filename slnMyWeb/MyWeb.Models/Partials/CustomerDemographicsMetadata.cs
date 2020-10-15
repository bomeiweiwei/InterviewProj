using MyWeb.Common;
using MyWeb.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace MyWeb.Models
{
    
    /// <summary>
    /// CustomerDemographics class
    /// </summary>
    [MetadataType(typeof(CustomerDemographicsMD))]
    public partial class CustomerDemographics
    {
    
    	/// <summary>
    	/// CustomerDemographics Metadata class
    	/// </summary>
    	public class CustomerDemographicsMD
    	{
    		    
    		/// <summary>
    		/// Customer Type ID
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("CustomerTypeID", typeof(NorthWindResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(NorthWindResource))]
            [MaxLength(10, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public string CustomerTypeID { get; set; }
    
    		    
    		/// <summary>
    		/// Customer Desc
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("CustomerDesc", typeof(NorthWindResource))]
    		public string CustomerDesc { get; set; }
    
    		    
    	}
    }
    
}
