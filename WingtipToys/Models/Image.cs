using System.ComponentModel.DataAnnotations;
namespace WingtipToys.Models
{
    public class Image {
        /// <summary>
        /// The Id of the entity
        /// </summary>
        ///
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        /// <summary>
        /// The name of the image. It can be different than actual file name.
        /// </summary>
        ///
        [Required, StringLength(100), Display(Name = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// The description of the image
        /// </summary>
        [Required, StringLength(10000), Display(Name = "Product Description"), DataType(DataType.MultilineText)]
        public string Description { get; set; }

        /// <summary>
        /// The path the actual image is stored (normally the blob storage reference)
        /// </summary>
        [Required, StringLength(100), Display(Name = "ImagePath")]
        public string ImagePath { get; set; }
    }
}
