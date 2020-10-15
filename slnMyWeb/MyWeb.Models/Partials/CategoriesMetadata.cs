using MyWeb.Common;
using MyWeb.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace MyWeb.Models
{
    
    /// <summary>
    /// Categories class
    /// </summary>
    [MetadataType(typeof(CategoriesMD))]
    public partial class Categories
    {
    
    	/// <summary>
    	/// Categories Metadata class
    	/// </summary>
    	public class CategoriesMD
    	{
    		    
    		/// <summary>
    		/// Category ID
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("CategoryID", typeof(NorthWindResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public int CategoryID { get; set; }
    
    		    
    		/// <summary>
    		/// Category Name
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("CategoryName", typeof(NorthWindResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(NorthWindResource))]
            [MaxLength(15, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public string CategoryName { get; set; }
    
    		    
    		/// <summary>
    		/// Description
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("Description", typeof(NorthWindResource))]
    		public string Description { get; set; }
    
    		    
    		/// <summary>
    		/// Picture
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("Picture", typeof(NorthWindResource))]
    		public byte[] Picture { get; set; }
    
    		    
    	}
    }
    
}
