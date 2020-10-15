using MyWeb.Common;
using MyWeb.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace MyWeb.Models
{
    
    /// <summary>
    /// Employees class
    /// </summary>
    [MetadataType(typeof(EmployeesMD))]
    public partial class Employees
    {
    
    	/// <summary>
    	/// Employees Metadata class
    	/// </summary>
    	public class EmployeesMD
    	{
    		    
    		/// <summary>
    		/// Employee ID
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("EmployeeID", typeof(NorthWindResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public int EmployeeID { get; set; }
    
    		    
    		/// <summary>
    		/// Last Name
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("LastName", typeof(NorthWindResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(NorthWindResource))]
            [MaxLength(20, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public string LastName { get; set; }
    
    		    
    		/// <summary>
    		/// First Name
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("FirstName", typeof(NorthWindResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(NorthWindResource))]
            [MaxLength(10, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public string FirstName { get; set; }
    
    		    
    		/// <summary>
    		/// Title
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("Title", typeof(NorthWindResource))]
            [MaxLength(30, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public string Title { get; set; }
    
    		    
    		/// <summary>
    		/// Title Of Courtesy
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("TitleOfCourtesy", typeof(NorthWindResource))]
            [MaxLength(25, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public string TitleOfCourtesy { get; set; }
    
    		    
    		/// <summary>
    		/// Birth Date
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("BirthDate", typeof(NorthWindResource))]
    		public Nullable<System.DateTime> BirthDate { get; set; }
    
    		    
    		/// <summary>
    		/// Hire Date
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("HireDate", typeof(NorthWindResource))]
    		public Nullable<System.DateTime> HireDate { get; set; }
    
    		    
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
    		/// Home Phone
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("HomePhone", typeof(NorthWindResource))]
            [MaxLength(24, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public string HomePhone { get; set; }
    
    		    
    		/// <summary>
    		/// Extension
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("Extension", typeof(NorthWindResource))]
            [MaxLength(4, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public string Extension { get; set; }
    
    		    
    		/// <summary>
    		/// Photo
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("Photo", typeof(NorthWindResource))]
    		public byte[] Photo { get; set; }
    
    		    
    		/// <summary>
    		/// Notes
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("Notes", typeof(NorthWindResource))]
    		public string Notes { get; set; }
    
    		    
    		/// <summary>
    		/// Reports To
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ReportsTo", typeof(NorthWindResource))]
    		public Nullable<int> ReportsTo { get; set; }
    
    		    
    		/// <summary>
    		/// Photo Path
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("PhotoPath", typeof(NorthWindResource))]
            [MaxLength(255, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(NorthWindResource))]
    		public string PhotoPath { get; set; }
    
    		    
    	}
    }
    
}
