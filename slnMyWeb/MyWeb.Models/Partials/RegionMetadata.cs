using MyWeb.Common;
using MyWeb.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace MyWeb.Models
{
    
    /// <summary>
    /// Region class
    /// </summary>
    [MetadataType(typeof(RegionMD))]
    public partial class Region
    {
    
    	/// <summary>
    	/// Region Metadata class
    	/// </summary>
    	public class RegionMD
    	{
    		    
    		/// <summary>
    		/// Region ID
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("RegionID", typeof(NorthWindResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public int RegionID { get; set; }
    
    		    
    		/// <summary>
    		/// Region Description
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("RegionDescription", typeof(NorthWindResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(NorthWindResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public string RegionDescription { get; set; }
    
    		    
    	}
    }
    
}
