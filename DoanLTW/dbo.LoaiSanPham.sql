CREATE TABLE [dbo].[LoaiSanPham] (
    [MaLoaiSanPham]  NVARCHAR (10) NOT NULL,
    [TenLoaiSanPham] NVARCHAR (50) NULL,
    [TinhTrang]      NVARCHAR (3)  CONSTRAINT [DF_LoaiSanPham_TinhTrang] DEFAULT 0 NULL,
    CONSTRAINT [PK_LoaiSanPham] PRIMARY KEY CLUSTERED ([MaLoaiSanPham] ASC)
);

