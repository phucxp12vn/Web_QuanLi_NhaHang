use QL_NHAHANG
go
--------------------------ChucVu-------------------------------
INSERT INTO ChucVu(MaChucVu,TenChucVu,[STATUS]) VALUES('CV01',N'Khách',1)
INSERT INTO ChucVu(MaChucVu,TenChucVu,[STATUS]) VALUES('CV02',N'VIP',1)
INSERT INTO ChucVu(MaChucVu,TenChucVu,[STATUS]) VALUES('CV03',N'Nhân Viên',1)

-------------------------DonViTinh--------------------------------
INSERT INTO DonViTinh(MaDVT,TenDVT,[STATUS]) VALUES('DVT01',N'Cái',1)
INSERT INTO DonViTinh(MaDVT,TenDVT,[STATUS]) VALUES('DVT02',N'Lon',1)
INSERT INTO DonViTinh(MaDVT,TenDVT,[STATUS]) VALUES('DVT03',N'Dĩa',1)
INSERT INTO DonViTinh(MaDVT,TenDVT,[STATUS]) VALUES('DVT04',N'Kg',1)
INSERT INTO DonViTinh(MaDVT,TenDVT,[STATUS]) VALUES('DVT05',N'Chai',1)
INSERT INTO DonViTinh(MaDVT,TenDVT,[STATUS]) VALUES('DVT06',N'Thùng',1)
INSERT INTO DonViTinh(MaDVT,TenDVT,[STATUS]) VALUES('DVT07',N'Con',1)

------------------------KhuyenMai---------------------------------
INSERT INTO KhuyenMai(MaKhuyenMai,TenKhuyenMai,NgayBatDau,NgayKetThuc,[STATUS]) VALUES('KM01',N'Đại tiệc hạ giá','08/01/2018','09/30/2018',1)
INSERT INTO KhuyenMai(MaKhuyenMai,TenKhuyenMai,NgayBatDau,NgayKetThuc,[STATUS]) VALUES('KM02',N'Lễ Hội Halloween','03/01/2017','04/08/2017',1)
INSERT INTO KhuyenMai(MaKhuyenMai,TenKhuyenMai,NgayBatDau,NgayKetThuc,[STATUS]) VALUES('KM03',N'Tết Nguyên Đán','02/04/2018','03/01/2018',1)
INSERT INTO KhuyenMai(MaKhuyenMai,TenKhuyenMai,NgayBatDau,NgayKetThuc,[STATUS]) VALUES('KM04',N'Lễ Thiếu Nhi','05/25/2018','06/03/2018',1)

-------------------------GiamGia--------------------------------
INSERT INTO GiamGia(MaGiamGia,PhanTramGiam,[STATUS]) VALUES('GG001',50,1)
INSERT INTO GiamGia(MaGiamGia,PhanTramGiam,[STATUS]) VALUES('GG002',30,1)
INSERT INTO GiamGia(MaGiamGia,PhanTramGiam,[STATUS]) VALUES('GG003',20,1)
INSERT INTO GiamGia(MaGiamGia,PhanTramGiam,[STATUS]) VALUES('GG004',0,1)

------------------------KhuVuc---------------------------------
INSERT INTO KhuVuc(MaKhu,SoGhe,[STATUS]) VALUES('KV01',4,1)
INSERT INTO KhuVuc(MaKhu,SoGhe,[STATUS]) VALUES('KV02',5,1)
INSERT INTO KhuVuc(MaKhu,SoGhe,[STATUS]) VALUES('KV03',7,1)
INSERT INTO KhuVuc(MaKhu,SoGhe,[STATUS]) VALUES('KV04',3,1)

-----------------------NhomMonAN----------------------------------
INSERT INTO NhomMonAN(MaNhomMon,TenNhomMon,[STATUS]) VALUES('NMA01',N'Hải Sản',1) 
INSERT INTO NhomMonAN(MaNhomMon,TenNhomMon,[STATUS]) VALUES('NMA02',N'Canh',1) 
INSERT INTO NhomMonAN(MaNhomMon,TenNhomMon,[STATUS]) VALUES('NMA03',N'Thịt',1)
INSERT INTO NhomMonAN(MaNhomMon,TenNhomMon,[STATUS]) VALUES('NMA04',N'Nước Uống',1)  

--------------------------Ban----------------------------------
INSERT INTO Ban(MaBan,MaKhu,SoGhe,[STATUS]) VALUES('B01','KV02',4,1)
INSERT INTO Ban(MaBan,MaKhu,SoGhe,[STATUS]) VALUES('B02','KV03',6,1)
INSERT INTO Ban(MaBan,MaKhu,SoGhe,[STATUS]) VALUES('B03','KV01',8,1)
INSERT INTO Ban(MaBan,MaKhu,SoGhe,[STATUS]) VALUES('B04','KV04',2,1)
INSERT INTO Ban(MaBan,MaKhu,SoGhe,[STATUS]) VALUES('B05','KV01',10,1)
INSERT INTO Ban(MaBan,MaKhu,SoGhe,[STATUS]) VALUES('B06','KV03',4,1)

------------------------NhaCungCap---------------------------------
INSERT INTO NhaCungCap(MaNCC,TenNCC,DiaChi,DienThoai,[STATUS]) VALUES('NCC01',N'Chợ Đầu Mối Phạm Văn Hai',N'300 Phạm Văn Hai , Phường 3 , Quận Tân Bình, TPHCM',018993631 ,1) --ALL KIND
INSERT INTO NhaCungCap(MaNCC,TenNCC,DiaChi,DienThoai,[STATUS]) VALUES('NCC02',N'Công Ty TMCP TNHH Thực phẩm Thiên Ân',N'47/6 Nguyễn Hiền , Phường 4, Q3, TPHCM',018925624,1) --ALL KIND
INSERT INTO NhaCungCap(MaNCC,TenNCC,DiaChi,DienThoai,[STATUS]) VALUES('NCC03',N'Bò Ngon',N'46 Đường 61, Phường Phước Long B, Quận 9, TPHCM',018542631,1) -- Thịt Bò
INSERT INTO NhaCungCap(MaNCC,TenNCC,DiaChi,DienThoai,[STATUS]) VALUES('NCC04',N'Long Bình Food',N'53 Đỗ Quang Đẩu, Phuờng Phạm Ngũ Lão, Quận 1, TPHCM',092531574,1)-- Thịt vịt
INSERT INTO NhaCungCap(MaNCC,TenNCC,DiaChi,DienThoai,[STATUS]) VALUES('NCC05',N'Long Hiền Gia Cầm',N'39 Cống Quỳnh , Phường 4 , Quận 1, TPHCM',088543612,1) -- Thịt gà
INSERT INTO NhaCungCap(MaNCC,TenNCC,DiaChi,DienThoai,[STATUS]) VALUES('NCC06',N'Công Ty TNHH Nông Sản Thực Phẩm Xanh Xanh',N'64/5Bb Ngô Chí Quốc, KP. 2, P. Bình Chiểu, Q. Thủ Đức, TPHCM',0126364251,1)--Rau
INSERT INTO NhaCungCap(MaNCC,TenNCC,DiaChi,DienThoai,[STATUS]) VALUES('NCC07',N'Suntory Pepsico Việt Nam',N'88 Đường Đồng Khởi, Quận 1, TPHCM',02838963519,1) --PEPSI
INSERT INTO NhaCungCap(MaNCC,TenNCC,DiaChi,DienThoai,[STATUS]) VALUES('NCC08',N'Coca Cola Việt Nam',N'485 Hà Nội, P. Linh Trung, Q. Thủ Đức, TPHCM , ',02838961000,1) --Coca
INSERT INTO NhaCungCap(MaNCC,TenNCC,DiaChi,DienThoai,[STATUS]) VALUES('NCC09',N'Công Ty Cổ Phần Gốm Sứ Sáng Tạo Việt Nam',N'21 Cộng Hòa, P.4, Q. Tân Bình, TPHCM ',02838100559,1)

------------------------MonAN---------------------------------
INSERT INTO MonAN(MaMonAn,MaNhomMon,TenMon,Gia,[STATUS]) VALUES('MOA001','NMA01',N'Hải Sản Tần Bí Xanh',70000,1)
INSERT INTO MonAN(MaMonAn,MaNhomMon,TenMon,Gia,[STATUS]) VALUES('MOA002','NMA02',N'Súp Bí Đỏ',100000,1)
INSERT INTO MonAN(MaMonAn,MaNhomMon,TenMon,Gia,[STATUS]) VALUES('MOA003','NMA03',N'Vịt Quay Thượng Hạng Long Đình',80000,1)
INSERT INTO MonAN(MaMonAn,MaNhomMon,TenMon,Gia,[STATUS]) VALUES('MOA004','NMA02',N'Canh chua đầu cá hồi',59000,1)
INSERT INTO MonAN(MaMonAn,MaNhomMon,TenMon,Gia,[STATUS]) VALUES('MOA005','NMA03',N'Chân Gà Kiểu Thái',76000,1)
INSERT INTO MonAN(MaMonAn,MaNhomMon,TenMon,Gia,[STATUS]) VALUES('MOA006','NMA01',N'Tôm Chao Vừng Trắng, Nước Cốt Chanh',63000,1)
INSERT INTO MonAN(MaMonAn,MaNhomMon,TenMon,Gia,[STATUS]) VALUES('MOA007','NMA02',N'Canh Rong Biển',20000,1)
INSERT INTO MonAN(MaMonAn,MaNhomMon,TenMon,Gia,[STATUS]) VALUES('MOA008','NMA01',N'Xôi Hấp Tôm',50000,1)
INSERT INTO MonAN(MaMonAn,MaNhomMon,TenMon,Gia,[STATUS]) VALUES('MOB001','NMA04',N'Coca Cola',20000,1)
INSERT INTO MonAN(MaMonAn,MaNhomMon,TenMon,Gia,[STATUS]) VALUES('MOB002','NMA04',N'Pepsi',22000,1)

----------------------TaiKhoan-----------------------------------
INSERT INTO TaiKhoan(MaTaiKhoan,MaChucVu,MatKhau,ATM,NgayTao,[STATUS]) VALUES('TK001','CV01','matkhau001','SacomBank','11/18/2017',1)
INSERT INTO TaiKhoan(MaTaiKhoan,MaChucVu,MatKhau,ATM,NgayTao,[STATUS]) VALUES('TK002','CV02','matkhau002','VietcomBank','01/19/2016',1)
INSERT INTO TaiKhoan(MaTaiKhoan,MaChucVu,MatKhau,ATM,NgayTao,[STATUS]) VALUES('TK003','CV01','matkhau003','TechcomBank','01/20/2016',1)
INSERT INTO TaiKhoan(MaTaiKhoan,MaChucVu,MatKhau,ATM,NgayTao,[STATUS]) VALUES('TK004','CV03','matkhau004','ACB','12/26/2015',1)
INSERT INTO TaiKhoan(MaTaiKhoan,MaChucVu,MatKhau,ATM,NgayTao,[STATUS]) VALUES('TK005','CV02','matkhau005','TPBank','05/23/2017',1)
INSERT INTO TaiKhoan(MaTaiKhoan,MaChucVu,MatKhau,ATM,NgayTao,[STATUS]) VALUES('TK006','CV01','matkhau006','ACB','04/14/2017',1)
INSERT INTO TaiKhoan(MaTaiKhoan,MaChucVu,MatKhau,ATM,NgayTao,[STATUS]) VALUES('TK007','CV01','matkhau007','ACB','10/07/2018',1)
INSERT INTO TaiKhoan(MaTaiKhoan,MaChucVu,MatKhau,ATM,NgayTao,[STATUS]) VALUES('TK008','CV03','matkhau008',NULL,'06/17/2017',1)

-------------------------HoaDon--------------------------------
INSERT INTO HoaDon(MaHD,TKLap,MaBan,MaGiamGia,NgayLap,GioVao,GioThanhToan,[STATUS]) VALUES('HD001','TK003','B01','GG001','02/14/2016','18:01:00','19:23:00',1)
INSERT INTO HoaDon(MaHD,TKLap,MaBan,MaGiamGia,NgayLap,GioVao,GioThanhToan,[STATUS]) VALUES('HD002','TK002','B02','GG004','04/03/2017','14:48:23','15:30:00',1)
INSERT INTO HoaDon(MaHD,TKLap,MaBan,MaGiamGia,NgayLap,GioVao,GioThanhToan,[STATUS]) VALUES('HD003','TK004','B05','GG004','02/01/2018','07:10:03','14:09:07',1)
INSERT INTO HoaDon(MaHD,TKLap,MaBan,MaGiamGia,NgayLap,GioVao,GioThanhToan,[STATUS]) VALUES('HD004','TK002','B06','GG003','04/07/2017','13:10:08','14:20:30',1)
INSERT INTO HoaDon(MaHD,TKLap,MaBan,MaGiamGia,NgayLap,GioVao,GioThanhToan,[STATUS]) VALUES('HD005','TK005','B02','GG004','08/17/2018','21:30:10','22:30:20',1)
INSERT INTO HoaDon(MaHD,TKLap,MaBan,MaGiamGia,NgayLap,GioVao,GioThanhToan,[STATUS]) VALUES('HD006','TK006','B01','GG002','06/18/2017','20:15:58','22:00:00',1)
INSERT INTO HoaDon(MaHD,TKLap,MaBan,MaGiamGia,NgayLap,GioVao,GioThanhToan,[STATUS]) VALUES('HD007','TK001','B04','GG003','05/29/2018','17:23:23','17:50:30',1)
INSERT INTO HoaDon(MaHD,TKLap,MaBan,MaGiamGia,NgayLap,GioVao,GioThanhToan,[STATUS]) VALUES('HD008','TK008','B03','GG004','09/14/2018','14:26:27','15:05:17',1)
INSERT INTO HoaDon(MaHD,TKLap,MaBan,MaGiamGia,NgayLap,GioVao,GioThanhToan,[STATUS]) VALUES('HD010','TK002','B03','GG004','01/05/2017','14:26:27','15:05:17',1)

--------------------------ChiTietHoaDon-------------------------------
INSERT INTO ChiTietHoaDon(MaHD,MaMonAn,SoLuong,ThanhTien,[STATUS]) VALUES('HD003','MOA002',1,100000,1) --xxx
INSERT INTO ChiTietHoaDon(MaHD,MaMonAn,SoLuong,ThanhTien,[STATUS]) VALUES('HD002','MOA001',6,70000,1) --xx
INSERT INTO ChiTietHoaDon(MaHD,MaMonAn,SoLuong,ThanhTien,[STATUS]) VALUES('HD001','MOB001',3,60000,1) --x KhuyeMai=NULL
INSERT INTO ChiTietHoaDon(MaHD,MaMonAn,SoLuong,ThanhTien,[STATUS]) VALUES('HD003','MOB001',5,90000,1) --xxx 10%
INSERT INTO ChiTietHoaDon(MaHD,MaMonAn,SoLuong,ThanhTien,[STATUS]) VALUES('HD004','MOA004',7,330.400,1) --xxxx 20$ (Đơn Giá * số lượng) - KhuyenMai*(Đơn Giá * số lượng) 
INSERT INTO ChiTietHoaDon(MaHD,MaMonAn,SoLuong,ThanhTien,[STATUS]) VALUES('HD002','MOA006',2,126000,1) --xx
INSERT INTO ChiTietHoaDon(MaHD,MaMonAn,SoLuong,ThanhTien,[STATUS]) VALUES('HD005','MOA001',4,266000,1)
INSERT INTO ChiTietHoaDon(MaHD,MaMonAn,SoLuong,ThanhTien,[STATUS]) VALUES('HD006','MOA005',2,152000,1)
INSERT INTO ChiTietHoaDon(MaHD,MaMonAn,SoLuong,ThanhTien,[STATUS]) VALUES('HD007','MOA004',6,354000,1)
INSERT INTO ChiTietHoaDon(MaHD,MaMonAn,SoLuong,ThanhTien,[STATUS]) VALUES('HD008','MOA003',3,240000,1)
/*TEST TRIGGER Check_HoaDon_KhuyenMai
INSERT INTO HoaDon(MaHD,TKLap,MaBan,MaGiamGia,NgayLap,GioVao,GioThanhToan,[STATUS]) VALUES('HD009','TK002','B03','GG004','02/26/2018','14:26:27','15:05:17',1)
INSERT INTO ChiTietHoaDon(MaHD,MaMonAn,SoLuong,ThanhTien,[STATUS]) VALUES('HD009','MOA003',3,NULL,1)
INSERT INTO ChiTietHoaDon(MaHD,MaMonAn,SoLuong,ThanhTien,[STATUS]) VALUES('HD009','MOB001',3,NULL,1)

DELETE FROM ChiTietHoaDon WHERE MaHD ='HD009'
SELECT * FROM HoaDon as hd
SELECT * FROM ChiTietHoaDon AS cthd

*/
-------------------------ChiTietKhuyenMai-----------------------------
INSERT INTO ChiTietKhuyenMai(MaMonAn,MaKhuyenMai,PhanTram,[STATUS]) VALUES('MOA001','KM01',5,1)
INSERT INTO ChiTietKhuyenMai(MaMonAn,MaKhuyenMai,PhanTram,[STATUS]) VALUES('MOA003','KM04',10,1)
INSERT INTO ChiTietKhuyenMai(MaMonAn,MaKhuyenMai,PhanTram,[STATUS]) VALUES('MOA004','KM02',20,1)
INSERT INTO ChiTietKhuyenMai(MaMonAn,MaKhuyenMai,PhanTram,[STATUS]) VALUES('MOA005','KM03',15,1)
INSERT INTO ChiTietKhuyenMai(MaMonAn,MaKhuyenMai,PhanTram,[STATUS]) VALUES('MOB001','KM03',10,1)

----------------------PhieuNhap-----------------------------------
INSERT INTO PhieuNhap(MaPhieuNhap,MaTaiKhoan,NgayLapPhieu,[STATUS]) VALUES('PN001','TK004','01/05/2018',1) -- Coca
INSERT INTO PhieuNhap(MaPhieuNhap,MaTaiKhoan,NgayLapPhieu,[STATUS]) VALUES('PN002','TK008','01/05/2018',1) --Phải là nhân viên
INSERT INTO PhieuNhap(MaPhieuNhap,MaTaiKhoan,NgayLapPhieu,[STATUS]) VALUES('PN003','TK008','01/05/2018',1) 
INSERT INTO PhieuNhap(MaPhieuNhap,MaTaiKhoan,NgayLapPhieu,[STATUS]) VALUES('PN004','TK008','01/05/2018',1) 
INSERT INTO PhieuNhap(MaPhieuNhap,MaTaiKhoan,NgayLapPhieu,[STATUS]) VALUES('PN005','TK004','01/05/2018',1) 
INSERT INTO PhieuNhap(MaPhieuNhap,MaTaiKhoan,NgayLapPhieu,[STATUS]) VALUES('PN006','TK008','01/05/2018',1) 
INSERT INTO PhieuNhap(MaPhieuNhap,MaTaiKhoan,NgayLapPhieu,[STATUS]) VALUES('PN007','TK004','01/05/2018',1)  

------------------------MatHang---------------------------------
INSERT INTO MatHang(MaMatHang,MaDVT,MaNCC,TenMatHang,SoLuongCon,GiaNhap,HanSuDung,[STATUS]) VALUES('MH001','DVT02','NCC08',N'Coca Cola',200,6000,'01/12/2018',1)
INSERT INTO MatHang(MaMatHang,MaDVT,MaNCC,TenMatHang,SoLuongCon,GiaNhap,HanSuDung,[STATUS]) VALUES('MH002','DVT02','NCC07',N'Pepsi',250,6500,'01/12/2018',1)
INSERT INTO MatHang(MaMatHang,MaDVT,MaNCC,TenMatHang,SoLuongCon,GiaNhap,HanSuDung,[STATUS]) VALUES('MH003','DVT04','NCC06',N'Rau Salad',15,2000,'05/08/2018',1)
INSERT INTO MatHang(MaMatHang,MaDVT,MaNCC,TenMatHang,SoLuongCon,GiaNhap,HanSuDung,[STATUS]) VALUES('MH004','DVT04','NCC06',N'Bí Đỏ',10,4000,'05/06/2018',1)
INSERT INTO MatHang(MaMatHang,MaDVT,MaNCC,TenMatHang,SoLuongCon,GiaNhap,HanSuDung,[STATUS]) VALUES('MH005','DVT01','NCC09',N'Dĩa sứ',60,25000,'05/06/2030',1)
INSERT INTO MatHang(MaMatHang,MaDVT,MaNCC,TenMatHang,SoLuongCon,GiaNhap,HanSuDung,[STATUS]) VALUES('MH006','DVT07','NCC04',N'Vịt',20,150000,'05/14/2018',1)
INSERT INTO MatHang(MaMatHang,MaDVT,MaNCC,TenMatHang,SoLuongCon,GiaNhap,HanSuDung,[STATUS]) VALUES('MH007','DVT07','NCC05',N'Gà',14,18000,'05/16/2018',1)
INSERT INTO MatHang(MaMatHang,MaDVT,MaNCC,TenMatHang,SoLuongCon,GiaNhap,HanSuDung,[STATUS]) VALUES('MH008','DVT04','NCC02',N'Tôm',30,30000,'05/10/2018',1)
INSERT INTO MatHang(MaMatHang,MaDVT,MaNCC,TenMatHang,SoLuongCon,GiaNhap,HanSuDung,[STATUS]) VALUES('MH009','DVT04','NCC06',N'Rong Biển',9,7800,'05/02/2018',1)
INSERT INTO MatHang(MaMatHang,MaDVT,MaNCC,TenMatHang,SoLuongCon,GiaNhap,HanSuDung,[STATUS]) VALUES('MH010','DVT04','NCC01',N'Cá Hồi',12,70000,'05/19/2018',1)
--INSERT INTO MatHang(MaMatHang,MaDVT,MaNCC,TenMatHang,SoLuongCon,GiaNhap,HanSuDung,[STATUS]) VALUES('MH011','DVT04','NCC01',N'Cá Hồi',14,70000,'05/19/2018',1)
--DELETE FROM MatHang WHERE MaMatHang = 'MH011'

--------------------------ChiTietPhieuNhap-------------------------------
INSERT INTO ChiTietPhieuNhap(MaMatHang,MaPhieuNhap,Soluong,DonGia,NgayNhan,[STATUS]) VALUES('MH001','PN001',30,6000,'01/12/2018',1)
INSERT INTO ChiTietPhieuNhap(MaMatHang,MaPhieuNhap,Soluong,DonGia,NgayNhan,[STATUS]) VALUES('MH002','PN002',20,6500,'01/12/2018',1)
INSERT INTO ChiTietPhieuNhap(MaMatHang,MaPhieuNhap,Soluong,DonGia,NgayNhan,[STATUS]) VALUES('MH003','PN005',21,2000,'01/12/2018',1)
INSERT INTO ChiTietPhieuNhap(MaMatHang,MaPhieuNhap,Soluong,DonGia,NgayNhan,[STATUS]) VALUES('MH004','PN004',30,4000,'01/12/2018',1)
INSERT INTO ChiTietPhieuNhap(MaMatHang,MaPhieuNhap,Soluong,DonGia,NgayNhan,[STATUS]) VALUES('MH005','PN003',15,25000,'01/12/2018',1)
INSERT INTO ChiTietPhieuNhap(MaMatHang,MaPhieuNhap,Soluong,DonGia,NgayNhan,[STATUS]) VALUES('MH006','PN002',14,150000,'01/12/2018',1)
INSERT INTO ChiTietPhieuNhap(MaMatHang,MaPhieuNhap,Soluong,DonGia,NgayNhan,[STATUS]) VALUES('MH007','PN001',3,18000,'01/12/2018',1)
INSERT INTO ChiTietPhieuNhap(MaMatHang,MaPhieuNhap,Soluong,DonGia,NgayNhan,[STATUS]) VALUES('MH008','PN005',8,30000,'01/12/2018',1)
INSERT INTO ChiTietPhieuNhap(MaMatHang,MaPhieuNhap,Soluong,DonGia,NgayNhan,[STATUS]) VALUES('MH009','PN006',9,7800,'01/12/2018',1)
INSERT INTO ChiTietPhieuNhap(MaMatHang,MaPhieuNhap,Soluong,DonGia,NgayNhan,[STATUS]) VALUES('MH010','PN007',25,70000,'01/12/2018',1)
INSERT INTO ChiTietPhieuNhap(MaMatHang,MaPhieuNhap,Soluong,DonGia,NgayNhan,[STATUS]) VALUES('MH011','PN007',23,70000,'01/12/2015',1)
--DELETE FROM ChiTietPhieuNhap WHERE MaMatHang = 'MH011'


----------------------ThanhPhan-----------------------------------
INSERT INTO ThanhPhan(MaMonAn,MaMatHang,SoLuong,GhiChu,[STATUS]) VALUES('MOA001','MH008',2,NULL,1)
INSERT INTO ThanhPhan(MaMonAn,MaMatHang,SoLuong,GhiChu,[STATUS]) VALUES('MOA001','MH009',1,NULL,1)
INSERT INTO ThanhPhan(MaMonAn,MaMatHang,SoLuong,GhiChu,[STATUS]) VALUES('MOA002','MH004',1,NULL,1)
INSERT INTO ThanhPhan(MaMonAn,MaMatHang,SoLuong,GhiChu,[STATUS]) VALUES('MOA003','MH006',3,NULL,1)
INSERT INTO ThanhPhan(MaMonAn,MaMatHang,SoLuong,GhiChu,[STATUS]) VALUES('MOA003','MH009',2,NULL,1)
INSERT INTO ThanhPhan(MaMonAn,MaMatHang,SoLuong,GhiChu,[STATUS]) VALUES('MOA004','MH010',1,NULL,1)
INSERT INTO ThanhPhan(MaMonAn,MaMatHang,SoLuong,GhiChu,[STATUS]) VALUES('MOA005','MH007',3,N'Ngon Cực',1)
INSERT INTO ThanhPhan(MaMonAn,MaMatHang,SoLuong,GhiChu,[STATUS]) VALUES('MOA006','MH008',4,NULL,1)
INSERT INTO ThanhPhan(MaMonAn,MaMatHang,SoLuong,GhiChu,[STATUS]) VALUES('MOA007','MH009',2,NULL,1)
INSERT INTO ThanhPhan(MaMonAn,MaMatHang,SoLuong,GhiChu,[STATUS]) VALUES('MOA008','MH008',2,NULL,1)



