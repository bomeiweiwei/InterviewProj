using MyWeb.Common;
using MyWeb.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace MyWeb.Models
{
    
    /// <summary>
    /// Territories class
    /// </summary>
    [MetadataType(typeof(TerritoriesMD))]
    public partial class Territories
    {
    
    	/// <summary>
    	/// Territories Metadata class
    	/// </summary>
    	public class TerritoriesMD
    	{
    		    
    		/// <summary>
    		/// Territory ID
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("TerritoryID", typeof(NorthWindResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(NorthWindResource))]
            [MaxLength(20, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public string TerritoryID { get; set; }
    
    		    
    		/// <summary>
    		/// Territory Description
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("TerritoryDescription", typeof(NorthWindResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(NorthWindResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public string TerritoryDescription { get; set; }
    
    		    
    		/// <summary>
    		/// Region ID
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("RegionID", typeof(NorthWindResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public int RegionID { get; set; }
    
    		    
    	}
    }
    
}
