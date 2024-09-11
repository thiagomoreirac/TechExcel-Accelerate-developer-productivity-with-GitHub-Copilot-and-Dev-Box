using System.ComponentModel.DataAnnotations;

namespace RazorPagesTestSample.Data
{
    #region snippet1
    public class Message
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(250, ErrorMessage = "The message cannot exceed 250 characters.")]
        public string Text { get; set; }
    }
    #endregion
}
