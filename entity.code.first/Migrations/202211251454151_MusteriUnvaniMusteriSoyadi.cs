namespace entity.code.first.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MusteriUnvaniMusteriSoyadi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategorilers",
                c => new
                    {
                        KategoriID = c.Int(nullable: false, identity: true),
                        KategoriAdi = c.String(),
                    })
                .PrimaryKey(t => t.KategoriID);
            
            CreateTable(
                "dbo.Urunlers",
                c => new
                    {
                        UrunID = c.Int(nullable: false, identity: true),
                        UrunAdi = c.String(),
                        UrunMarkasi = c.String(),
                        UrunKategorisi = c.String(),
                        UrunStok = c.Int(nullable: false),
                        Aciklama = c.String(),
                        Kategori_KategoriID = c.Int(),
                    })
                .PrimaryKey(t => t.UrunID)
                .ForeignKey("dbo.Kategorilers", t => t.Kategori_KategoriID)
                .Index(t => t.Kategori_KategoriID);
            
            CreateTable(
                "dbo.Musterilers",
                c => new
                    {
                        MusteriID = c.Int(nullable: false, identity: true),
                        MusteriAdi = c.String(),
                        MusteriUnvani = c.String(),
                    })
                .PrimaryKey(t => t.MusteriID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Urunlers", "Kategori_KategoriID", "dbo.Kategorilers");
            DropIndex("dbo.Urunlers", new[] { "Kategori_KategoriID" });
            DropTable("dbo.Musterilers");
            DropTable("dbo.Urunlers");
            DropTable("dbo.Kategorilers");
        }
    }
}
