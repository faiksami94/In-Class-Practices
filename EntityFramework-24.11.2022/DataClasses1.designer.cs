﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFramework_24._11._2022
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="kuzeyyeli")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertKategoriler(Kategoriler instance);
    partial void UpdateKategoriler(Kategoriler instance);
    partial void DeleteKategoriler(Kategoriler instance);
    partial void InsertSatis_Detaylari(Satis_Detaylari instance);
    partial void UpdateSatis_Detaylari(Satis_Detaylari instance);
    partial void DeleteSatis_Detaylari(Satis_Detaylari instance);
    partial void InsertTedarikciler(Tedarikciler instance);
    partial void UpdateTedarikciler(Tedarikciler instance);
    partial void DeleteTedarikciler(Tedarikciler instance);
    partial void InsertUrunler(Urunler instance);
    partial void UpdateUrunler(Urunler instance);
    partial void DeleteUrunler(Urunler instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::EntityFramework_24._11._2022.Properties.Settings.Default.kuzeyyeliConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Kategoriler> Kategorilers
		{
			get
			{
				return this.GetTable<Kategoriler>();
			}
		}
		
		public System.Data.Linq.Table<Satis_Detaylari> Satis_Detaylaris
		{
			get
			{
				return this.GetTable<Satis_Detaylari>();
			}
		}
		
		public System.Data.Linq.Table<Tedarikciler> Tedarikcilers
		{
			get
			{
				return this.GetTable<Tedarikciler>();
			}
		}
		
		public System.Data.Linq.Table<Urunler> Urunlers
		{
			get
			{
				return this.GetTable<Urunler>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Kategoriler")]
	public partial class Kategoriler : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _KategoriID;
		
		private string _KategoriAdi;
		
		private string _Tanimi;
		
		private System.Data.Linq.Binary _Resim;
		
		private EntitySet<Urunler> _Urunlers;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnKategoriIDChanging(int value);
    partial void OnKategoriIDChanged();
    partial void OnKategoriAdiChanging(string value);
    partial void OnKategoriAdiChanged();
    partial void OnTanimiChanging(string value);
    partial void OnTanimiChanged();
    partial void OnResimChanging(System.Data.Linq.Binary value);
    partial void OnResimChanged();
    #endregion
		
		public Kategoriler()
		{
			this._Urunlers = new EntitySet<Urunler>(new Action<Urunler>(this.attach_Urunlers), new Action<Urunler>(this.detach_Urunlers));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KategoriID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int KategoriID
		{
			get
			{
				return this._KategoriID;
			}
			set
			{
				if ((this._KategoriID != value))
				{
					this.OnKategoriIDChanging(value);
					this.SendPropertyChanging();
					this._KategoriID = value;
					this.SendPropertyChanged("KategoriID");
					this.OnKategoriIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KategoriAdi", DbType="NVarChar(15) NOT NULL", CanBeNull=false)]
		public string KategoriAdi
		{
			get
			{
				return this._KategoriAdi;
			}
			set
			{
				if ((this._KategoriAdi != value))
				{
					this.OnKategoriAdiChanging(value);
					this.SendPropertyChanging();
					this._KategoriAdi = value;
					this.SendPropertyChanged("KategoriAdi");
					this.OnKategoriAdiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tanimi", DbType="NText", UpdateCheck=UpdateCheck.Never)]
		public string Tanimi
		{
			get
			{
				return this._Tanimi;
			}
			set
			{
				if ((this._Tanimi != value))
				{
					this.OnTanimiChanging(value);
					this.SendPropertyChanging();
					this._Tanimi = value;
					this.SendPropertyChanged("Tanimi");
					this.OnTanimiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Resim", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Resim
		{
			get
			{
				return this._Resim;
			}
			set
			{
				if ((this._Resim != value))
				{
					this.OnResimChanging(value);
					this.SendPropertyChanging();
					this._Resim = value;
					this.SendPropertyChanged("Resim");
					this.OnResimChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Kategoriler_Urunler", Storage="_Urunlers", ThisKey="KategoriID", OtherKey="KategoriID")]
		public EntitySet<Urunler> Urunlers
		{
			get
			{
				return this._Urunlers;
			}
			set
			{
				this._Urunlers.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Urunlers(Urunler entity)
		{
			this.SendPropertyChanging();
			entity.Kategoriler = this;
		}
		
		private void detach_Urunlers(Urunler entity)
		{
			this.SendPropertyChanging();
			entity.Kategoriler = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Satis Detaylari]")]
	public partial class Satis_Detaylari : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SatisID;
		
		private int _UrunID;
		
		private decimal _BirimFiyati;
		
		private short _Miktar;
		
		private float _İndirim;
		
		private EntityRef<Urunler> _Urunler;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSatisIDChanging(int value);
    partial void OnSatisIDChanged();
    partial void OnUrunIDChanging(int value);
    partial void OnUrunIDChanged();
    partial void OnBirimFiyatiChanging(decimal value);
    partial void OnBirimFiyatiChanged();
    partial void OnMiktarChanging(short value);
    partial void OnMiktarChanged();
    partial void OnİndirimChanging(float value);
    partial void OnİndirimChanged();
    #endregion
		
		public Satis_Detaylari()
		{
			this._Urunler = default(EntityRef<Urunler>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SatisID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int SatisID
		{
			get
			{
				return this._SatisID;
			}
			set
			{
				if ((this._SatisID != value))
				{
					this.OnSatisIDChanging(value);
					this.SendPropertyChanging();
					this._SatisID = value;
					this.SendPropertyChanged("SatisID");
					this.OnSatisIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UrunID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int UrunID
		{
			get
			{
				return this._UrunID;
			}
			set
			{
				if ((this._UrunID != value))
				{
					if (this._Urunler.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUrunIDChanging(value);
					this.SendPropertyChanging();
					this._UrunID = value;
					this.SendPropertyChanged("UrunID");
					this.OnUrunIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BirimFiyati", DbType="Money NOT NULL")]
		public decimal BirimFiyati
		{
			get
			{
				return this._BirimFiyati;
			}
			set
			{
				if ((this._BirimFiyati != value))
				{
					this.OnBirimFiyatiChanging(value);
					this.SendPropertyChanging();
					this._BirimFiyati = value;
					this.SendPropertyChanged("BirimFiyati");
					this.OnBirimFiyatiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Miktar", DbType="SmallInt NOT NULL")]
		public short Miktar
		{
			get
			{
				return this._Miktar;
			}
			set
			{
				if ((this._Miktar != value))
				{
					this.OnMiktarChanging(value);
					this.SendPropertyChanging();
					this._Miktar = value;
					this.SendPropertyChanged("Miktar");
					this.OnMiktarChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_İndirim", DbType="Real NOT NULL")]
		public float İndirim
		{
			get
			{
				return this._İndirim;
			}
			set
			{
				if ((this._İndirim != value))
				{
					this.OnİndirimChanging(value);
					this.SendPropertyChanging();
					this._İndirim = value;
					this.SendPropertyChanged("İndirim");
					this.OnİndirimChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Urunler_Satis_Detaylari", Storage="_Urunler", ThisKey="UrunID", OtherKey="UrunID", IsForeignKey=true)]
		public Urunler Urunler
		{
			get
			{
				return this._Urunler.Entity;
			}
			set
			{
				Urunler previousValue = this._Urunler.Entity;
				if (((previousValue != value) 
							|| (this._Urunler.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Urunler.Entity = null;
						previousValue.Satis_Detaylaris.Remove(this);
					}
					this._Urunler.Entity = value;
					if ((value != null))
					{
						value.Satis_Detaylaris.Add(this);
						this._UrunID = value.UrunID;
					}
					else
					{
						this._UrunID = default(int);
					}
					this.SendPropertyChanged("Urunler");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tedarikciler")]
	public partial class Tedarikciler : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _TedarikciID;
		
		private string _SirketAdi;
		
		private string _MusteriAdi;
		
		private string _MusteriUnvani;
		
		private string _Adres;
		
		private string _Sehir;
		
		private string _Bolge;
		
		private string _PostaKodu;
		
		private string _Ulke;
		
		private string _Telefon;
		
		private string _Faks;
		
		private string _WebSayfasi;
		
		private EntitySet<Urunler> _Urunlers;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTedarikciIDChanging(int value);
    partial void OnTedarikciIDChanged();
    partial void OnSirketAdiChanging(string value);
    partial void OnSirketAdiChanged();
    partial void OnMusteriAdiChanging(string value);
    partial void OnMusteriAdiChanged();
    partial void OnMusteriUnvaniChanging(string value);
    partial void OnMusteriUnvaniChanged();
    partial void OnAdresChanging(string value);
    partial void OnAdresChanged();
    partial void OnSehirChanging(string value);
    partial void OnSehirChanged();
    partial void OnBolgeChanging(string value);
    partial void OnBolgeChanged();
    partial void OnPostaKoduChanging(string value);
    partial void OnPostaKoduChanged();
    partial void OnUlkeChanging(string value);
    partial void OnUlkeChanged();
    partial void OnTelefonChanging(string value);
    partial void OnTelefonChanged();
    partial void OnFaksChanging(string value);
    partial void OnFaksChanged();
    partial void OnWebSayfasiChanging(string value);
    partial void OnWebSayfasiChanged();
    #endregion
		
		public Tedarikciler()
		{
			this._Urunlers = new EntitySet<Urunler>(new Action<Urunler>(this.attach_Urunlers), new Action<Urunler>(this.detach_Urunlers));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TedarikciID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int TedarikciID
		{
			get
			{
				return this._TedarikciID;
			}
			set
			{
				if ((this._TedarikciID != value))
				{
					this.OnTedarikciIDChanging(value);
					this.SendPropertyChanging();
					this._TedarikciID = value;
					this.SendPropertyChanged("TedarikciID");
					this.OnTedarikciIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SirketAdi", DbType="NVarChar(40) NOT NULL", CanBeNull=false)]
		public string SirketAdi
		{
			get
			{
				return this._SirketAdi;
			}
			set
			{
				if ((this._SirketAdi != value))
				{
					this.OnSirketAdiChanging(value);
					this.SendPropertyChanging();
					this._SirketAdi = value;
					this.SendPropertyChanged("SirketAdi");
					this.OnSirketAdiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MusteriAdi", DbType="NVarChar(30)")]
		public string MusteriAdi
		{
			get
			{
				return this._MusteriAdi;
			}
			set
			{
				if ((this._MusteriAdi != value))
				{
					this.OnMusteriAdiChanging(value);
					this.SendPropertyChanging();
					this._MusteriAdi = value;
					this.SendPropertyChanged("MusteriAdi");
					this.OnMusteriAdiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MusteriUnvani", DbType="NVarChar(30)")]
		public string MusteriUnvani
		{
			get
			{
				return this._MusteriUnvani;
			}
			set
			{
				if ((this._MusteriUnvani != value))
				{
					this.OnMusteriUnvaniChanging(value);
					this.SendPropertyChanging();
					this._MusteriUnvani = value;
					this.SendPropertyChanged("MusteriUnvani");
					this.OnMusteriUnvaniChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Adres", DbType="NVarChar(60)")]
		public string Adres
		{
			get
			{
				return this._Adres;
			}
			set
			{
				if ((this._Adres != value))
				{
					this.OnAdresChanging(value);
					this.SendPropertyChanging();
					this._Adres = value;
					this.SendPropertyChanged("Adres");
					this.OnAdresChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sehir", DbType="NVarChar(15)")]
		public string Sehir
		{
			get
			{
				return this._Sehir;
			}
			set
			{
				if ((this._Sehir != value))
				{
					this.OnSehirChanging(value);
					this.SendPropertyChanging();
					this._Sehir = value;
					this.SendPropertyChanged("Sehir");
					this.OnSehirChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Bolge", DbType="NVarChar(15)")]
		public string Bolge
		{
			get
			{
				return this._Bolge;
			}
			set
			{
				if ((this._Bolge != value))
				{
					this.OnBolgeChanging(value);
					this.SendPropertyChanging();
					this._Bolge = value;
					this.SendPropertyChanged("Bolge");
					this.OnBolgeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostaKodu", DbType="NVarChar(10)")]
		public string PostaKodu
		{
			get
			{
				return this._PostaKodu;
			}
			set
			{
				if ((this._PostaKodu != value))
				{
					this.OnPostaKoduChanging(value);
					this.SendPropertyChanging();
					this._PostaKodu = value;
					this.SendPropertyChanged("PostaKodu");
					this.OnPostaKoduChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ulke", DbType="NVarChar(15)")]
		public string Ulke
		{
			get
			{
				return this._Ulke;
			}
			set
			{
				if ((this._Ulke != value))
				{
					this.OnUlkeChanging(value);
					this.SendPropertyChanging();
					this._Ulke = value;
					this.SendPropertyChanged("Ulke");
					this.OnUlkeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telefon", DbType="NVarChar(24)")]
		public string Telefon
		{
			get
			{
				return this._Telefon;
			}
			set
			{
				if ((this._Telefon != value))
				{
					this.OnTelefonChanging(value);
					this.SendPropertyChanging();
					this._Telefon = value;
					this.SendPropertyChanged("Telefon");
					this.OnTelefonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Faks", DbType="NVarChar(24)")]
		public string Faks
		{
			get
			{
				return this._Faks;
			}
			set
			{
				if ((this._Faks != value))
				{
					this.OnFaksChanging(value);
					this.SendPropertyChanging();
					this._Faks = value;
					this.SendPropertyChanged("Faks");
					this.OnFaksChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WebSayfasi", DbType="NText", UpdateCheck=UpdateCheck.Never)]
		public string WebSayfasi
		{
			get
			{
				return this._WebSayfasi;
			}
			set
			{
				if ((this._WebSayfasi != value))
				{
					this.OnWebSayfasiChanging(value);
					this.SendPropertyChanging();
					this._WebSayfasi = value;
					this.SendPropertyChanged("WebSayfasi");
					this.OnWebSayfasiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Tedarikciler_Urunler", Storage="_Urunlers", ThisKey="TedarikciID", OtherKey="TedarikciID")]
		public EntitySet<Urunler> Urunlers
		{
			get
			{
				return this._Urunlers;
			}
			set
			{
				this._Urunlers.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Urunlers(Urunler entity)
		{
			this.SendPropertyChanging();
			entity.Tedarikciler = this;
		}
		
		private void detach_Urunlers(Urunler entity)
		{
			this.SendPropertyChanging();
			entity.Tedarikciler = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Urunler")]
	public partial class Urunler : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UrunID;
		
		private string _UrunAdi;
		
		private System.Nullable<int> _TedarikciID;
		
		private System.Nullable<int> _KategoriID;
		
		private string _BirimdekiMiktar;
		
		private System.Nullable<decimal> _BirimFiyati;
		
		private System.Nullable<short> _HedefStokDuzeyi;
		
		private System.Nullable<short> _YeniSatis;
		
		private System.Nullable<short> _EnAzYenidenSatisMikatari;
		
		private bool _Sonlandi;
		
		private EntitySet<Satis_Detaylari> _Satis_Detaylaris;
		
		private EntityRef<Kategoriler> _Kategoriler;
		
		private EntityRef<Tedarikciler> _Tedarikciler;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUrunIDChanging(int value);
    partial void OnUrunIDChanged();
    partial void OnUrunAdiChanging(string value);
    partial void OnUrunAdiChanged();
    partial void OnTedarikciIDChanging(System.Nullable<int> value);
    partial void OnTedarikciIDChanged();
    partial void OnKategoriIDChanging(System.Nullable<int> value);
    partial void OnKategoriIDChanged();
    partial void OnBirimdekiMiktarChanging(string value);
    partial void OnBirimdekiMiktarChanged();
    partial void OnBirimFiyatiChanging(System.Nullable<decimal> value);
    partial void OnBirimFiyatiChanged();
    partial void OnHedefStokDuzeyiChanging(System.Nullable<short> value);
    partial void OnHedefStokDuzeyiChanged();
    partial void OnYeniSatisChanging(System.Nullable<short> value);
    partial void OnYeniSatisChanged();
    partial void OnEnAzYenidenSatisMikatariChanging(System.Nullable<short> value);
    partial void OnEnAzYenidenSatisMikatariChanged();
    partial void OnSonlandiChanging(bool value);
    partial void OnSonlandiChanged();
    #endregion
		
		public Urunler()
		{
			this._Satis_Detaylaris = new EntitySet<Satis_Detaylari>(new Action<Satis_Detaylari>(this.attach_Satis_Detaylaris), new Action<Satis_Detaylari>(this.detach_Satis_Detaylaris));
			this._Kategoriler = default(EntityRef<Kategoriler>);
			this._Tedarikciler = default(EntityRef<Tedarikciler>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UrunID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int UrunID
		{
			get
			{
				return this._UrunID;
			}
			set
			{
				if ((this._UrunID != value))
				{
					this.OnUrunIDChanging(value);
					this.SendPropertyChanging();
					this._UrunID = value;
					this.SendPropertyChanged("UrunID");
					this.OnUrunIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UrunAdi", DbType="NVarChar(40) NOT NULL", CanBeNull=false)]
		public string UrunAdi
		{
			get
			{
				return this._UrunAdi;
			}
			set
			{
				if ((this._UrunAdi != value))
				{
					this.OnUrunAdiChanging(value);
					this.SendPropertyChanging();
					this._UrunAdi = value;
					this.SendPropertyChanged("UrunAdi");
					this.OnUrunAdiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TedarikciID", DbType="Int")]
		public System.Nullable<int> TedarikciID
		{
			get
			{
				return this._TedarikciID;
			}
			set
			{
				if ((this._TedarikciID != value))
				{
					if (this._Tedarikciler.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTedarikciIDChanging(value);
					this.SendPropertyChanging();
					this._TedarikciID = value;
					this.SendPropertyChanged("TedarikciID");
					this.OnTedarikciIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KategoriID", DbType="Int")]
		public System.Nullable<int> KategoriID
		{
			get
			{
				return this._KategoriID;
			}
			set
			{
				if ((this._KategoriID != value))
				{
					if (this._Kategoriler.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnKategoriIDChanging(value);
					this.SendPropertyChanging();
					this._KategoriID = value;
					this.SendPropertyChanged("KategoriID");
					this.OnKategoriIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BirimdekiMiktar", DbType="NVarChar(20)")]
		public string BirimdekiMiktar
		{
			get
			{
				return this._BirimdekiMiktar;
			}
			set
			{
				if ((this._BirimdekiMiktar != value))
				{
					this.OnBirimdekiMiktarChanging(value);
					this.SendPropertyChanging();
					this._BirimdekiMiktar = value;
					this.SendPropertyChanged("BirimdekiMiktar");
					this.OnBirimdekiMiktarChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BirimFiyati", DbType="Money")]
		public System.Nullable<decimal> BirimFiyati
		{
			get
			{
				return this._BirimFiyati;
			}
			set
			{
				if ((this._BirimFiyati != value))
				{
					this.OnBirimFiyatiChanging(value);
					this.SendPropertyChanging();
					this._BirimFiyati = value;
					this.SendPropertyChanged("BirimFiyati");
					this.OnBirimFiyatiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HedefStokDuzeyi", DbType="SmallInt")]
		public System.Nullable<short> HedefStokDuzeyi
		{
			get
			{
				return this._HedefStokDuzeyi;
			}
			set
			{
				if ((this._HedefStokDuzeyi != value))
				{
					this.OnHedefStokDuzeyiChanging(value);
					this.SendPropertyChanging();
					this._HedefStokDuzeyi = value;
					this.SendPropertyChanged("HedefStokDuzeyi");
					this.OnHedefStokDuzeyiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_YeniSatis", DbType="SmallInt")]
		public System.Nullable<short> YeniSatis
		{
			get
			{
				return this._YeniSatis;
			}
			set
			{
				if ((this._YeniSatis != value))
				{
					this.OnYeniSatisChanging(value);
					this.SendPropertyChanging();
					this._YeniSatis = value;
					this.SendPropertyChanged("YeniSatis");
					this.OnYeniSatisChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EnAzYenidenSatisMikatari", DbType="SmallInt")]
		public System.Nullable<short> EnAzYenidenSatisMikatari
		{
			get
			{
				return this._EnAzYenidenSatisMikatari;
			}
			set
			{
				if ((this._EnAzYenidenSatisMikatari != value))
				{
					this.OnEnAzYenidenSatisMikatariChanging(value);
					this.SendPropertyChanging();
					this._EnAzYenidenSatisMikatari = value;
					this.SendPropertyChanged("EnAzYenidenSatisMikatari");
					this.OnEnAzYenidenSatisMikatariChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sonlandi", DbType="Bit NOT NULL")]
		public bool Sonlandi
		{
			get
			{
				return this._Sonlandi;
			}
			set
			{
				if ((this._Sonlandi != value))
				{
					this.OnSonlandiChanging(value);
					this.SendPropertyChanging();
					this._Sonlandi = value;
					this.SendPropertyChanged("Sonlandi");
					this.OnSonlandiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Urunler_Satis_Detaylari", Storage="_Satis_Detaylaris", ThisKey="UrunID", OtherKey="UrunID")]
		public EntitySet<Satis_Detaylari> Satis_Detaylaris
		{
			get
			{
				return this._Satis_Detaylaris;
			}
			set
			{
				this._Satis_Detaylaris.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Kategoriler_Urunler", Storage="_Kategoriler", ThisKey="KategoriID", OtherKey="KategoriID", IsForeignKey=true, DeleteRule="SET DEFAULT")]
		public Kategoriler Kategoriler
		{
			get
			{
				return this._Kategoriler.Entity;
			}
			set
			{
				Kategoriler previousValue = this._Kategoriler.Entity;
				if (((previousValue != value) 
							|| (this._Kategoriler.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Kategoriler.Entity = null;
						previousValue.Urunlers.Remove(this);
					}
					this._Kategoriler.Entity = value;
					if ((value != null))
					{
						value.Urunlers.Add(this);
						this._KategoriID = value.KategoriID;
					}
					else
					{
						this._KategoriID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Kategoriler");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Tedarikciler_Urunler", Storage="_Tedarikciler", ThisKey="TedarikciID", OtherKey="TedarikciID", IsForeignKey=true)]
		public Tedarikciler Tedarikciler
		{
			get
			{
				return this._Tedarikciler.Entity;
			}
			set
			{
				Tedarikciler previousValue = this._Tedarikciler.Entity;
				if (((previousValue != value) 
							|| (this._Tedarikciler.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Tedarikciler.Entity = null;
						previousValue.Urunlers.Remove(this);
					}
					this._Tedarikciler.Entity = value;
					if ((value != null))
					{
						value.Urunlers.Add(this);
						this._TedarikciID = value.TedarikciID;
					}
					else
					{
						this._TedarikciID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Tedarikciler");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Satis_Detaylaris(Satis_Detaylari entity)
		{
			this.SendPropertyChanging();
			entity.Urunler = this;
		}
		
		private void detach_Satis_Detaylaris(Satis_Detaylari entity)
		{
			this.SendPropertyChanging();
			entity.Urunler = null;
		}
	}
}
#pragma warning restore 1591
