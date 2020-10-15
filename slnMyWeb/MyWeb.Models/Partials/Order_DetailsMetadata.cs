using MyWeb.Common;
using MyWeb.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace MyWeb.Models
{
    
    /// <summary>
    /// Order_Details class
    /// </summary>
    [MetadataType(typeof(Order_DetailsMD))]
    public partial class Order_Details
    {
    
    	/// <summary>
    	/// Order_Details Metadata class
    	/// </summary>
    	public class Order_DetailsMD
    	{
    		    
    		/// <summary>
    		/// Order ID
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("OrderID", typeof(NorthWindResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public int OrderID { get; set; }
    
    		    
    		/// <summary>
    		/// Product ID
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ProductID", typeof(NorthWindResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public int ProductID { get; set; }
    
    		    
    		/// <summary>
    		/// Unit Price
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("UnitPrice", typeof(NorthWindResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public decimal UnitPrice { get; set; }
    
    		    
    		/// <summary>
    		/// Quantity
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("Quantity", typeof(NorthWindResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public short Quantity { get; set; }
    
    		    
    		/// <summary>
    		/// Discount
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("Discount", typeof(NorthWindResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public float Discount { get; set; }
    
    		    
    	}
    }
    
}
