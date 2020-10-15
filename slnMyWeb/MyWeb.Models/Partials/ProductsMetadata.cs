using MyWeb.Common;
using MyWeb.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace MyWeb.Models
{
    
    /// <summary>
    /// Products class
    /// </summary>
    [MetadataType(typeof(ProductsMD))]
    public partial class Products
    {
    
    	/// <summary>
    	/// Products Metadata class
    	/// </summary>
    	public class ProductsMD
    	{
    		    
    		/// <summary>
    		/// Product ID
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ProductID", typeof(NorthWindResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public int ProductID { get; set; }
    
    		    
    		/// <summary>
    		/// Product Name
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ProductName", typeof(NorthWindResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(NorthWindResource))]
            [MaxLength(40, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public string ProductName { get; set; }
    
    		    
    		/// <summary>
    		/// Supplier ID
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("SupplierID", typeof(NorthWindResource))]
    		public Nullable<int> SupplierID { get; set; }
    
    		    
    		/// <summary>
    		/// Category ID
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("CategoryID", typeof(NorthWindResource))]
    		public Nullable<int> CategoryID { get; set; }
    
    		    
    		/// <summary>
    		/// Quantity Per Unit
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("QuantityPerUnit", typeof(NorthWindResource))]
            [MaxLength(20, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public string QuantityPerUnit { get; set; }
    
    		    
    		/// <summary>
    		/// Unit Price
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("UnitPrice", typeof(NorthWindResource))]
    		public Nullable<decimal> UnitPrice { get; set; }
    
    		    
    		/// <summary>
    		/// Units In Stock
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("UnitsInStock", typeof(NorthWindResource))]
    		public Nullable<short> UnitsInStock { get; set; }
    
    		    
    		/// <summary>
    		/// Units On Order
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("UnitsOnOrder", typeof(NorthWindResource))]
    		public Nullable<short> UnitsOnOrder { get; set; }
    
    		    
    		/// <summary>
    		/// Reorder Level
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ReorderLevel", typeof(NorthWindResource))]
    		public Nullable<short> ReorderLevel { get; set; }
    
    		    
    		/// <summary>
    		/// Discontinued
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("Discontinued", typeof(NorthWindResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public bool Discontinued { get; set; }
    
    		    
    	}
    }
    
}
