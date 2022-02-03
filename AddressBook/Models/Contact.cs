using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AddressBook.Models;

public class Contact
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    [Required]
    [Display(Name = "First Name")]
    [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at a max {1} characters long.", MinimumLength = 2)]
    public string? FirstName { get; set; }

    [Required]
    [Display(Name = "Last Name")]
    [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at a max {1} characters long.", MinimumLength = 2)]
    public string? LastName { get; set; }

    [NotMapped]
    // NotMapped means that this data does not need to be in the db
    public string? FullName { get { return $"{FirstName} {LastName}"; } }
    
    [DataType(DataType.Date)]
    public DateTime? Birthday { get; set; }
    
    [Required]
    public string? Address1 { get; set; }
    
    public string? Address2 { get; set; }
    
    [Required]
    public string? City { get; set; }
    
    [Required]
    public string? State { get; set; }
    
    public int? Zip { get; set; }
    
    [DataType(DataType.EmailAddress)]
    public string? Email { get; set; }
    
    [DataType(DataType.PhoneNumber)]
    public string? PhoneNumber { get; set; }
    
    [DataType(DataType.Date)]
    public DateTime Created { get; set; }
    
    [NotMapped]
    [DataType(DataType.Upload)]
    [Display(Name = "Contact Image")]
    public IFormFile? ImageFile { get; set; }
    
    public byte[]? ImageData { get; set; }
    public string? ImageType { get; set; }
    
    // Navigation Properties
    public virtual AppUser? User { get; set; }

    public virtual ICollection<Category> Categories { get; set; } = new HashSet<Category>();

}