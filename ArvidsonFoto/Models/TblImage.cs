﻿#nullable disable
namespace ArvidsonFoto.Models;

public partial class TblImage
{
    public int Id { get; set; }
    public int ImageId { get; set; }
    public int? ImageHuvudfamilj { get; set; }
    public int? ImageFamilj { get; set; }
    public int ImageArt { get; set; }
    public string ImageUrl { get; set; }
    public DateTime? ImageDate { get; set; }
    public string ImageDescription { get; set; }
    public DateTime ImageUpdate { get; set; }

    /// <summary>Inte något fält i databasen, men kan sättas ett namn, om det är en kategori som sökts fram. </summary>
    [NotMapped]
    public string Name { get; set; }
}