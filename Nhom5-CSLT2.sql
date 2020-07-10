
------ sân bóng
create table sanbong
(
 masan char(10) primary key not null,
 tensan nvarchar(50),
 diachi nvarchar(50),
 soghe int
 )
 ----- tỉnh
 create table tinh (
 matinh char(10) primary key not null,
 tentinh nvarchar(50)
 )
 ------ quốc tịch
 create table quoctich(
 maquoctich char(10) primary key not null,
 tenquoctich nvarchar(50)
 )
 ------ vị trí
 create table vitri(
 mavitri char(10) primary key not null,
 tenvitri nvarchar(50)
 )
 ------ đội bóng
 create table doibong(
 madoi char(10) primary key not null,
 tendoi nvarchar(50),
 masan char(10),
 HLV  nvarchar(50),
 matinh char(10),
 /*logo*/ 
 diem float,
 sobanthang int,
 sobanthua int,
 soluongcauthu int,
 constraint fk_MS foreign key (masan) references sanbong(masan),
 constraint fk_MT foreign key (matinh) references tinh(matinh)
 )
 ------- cầu thủ
 create table cauthu(
 macauthu char(10) primary key not null,
 madoi char(10),
 tencauthu nvarchar(50),
 vitri char(10),
 ngaysinh datetime,
 soao int,
 sobanthang int,
 sothevang int,
 sothedo int,
 maquoctich char(10),
 solanrasan int,
 /* ảnh*/
 constraint fk_MD foreign key (madoi) references doibong(madoi),
 constraint fk_VT foreign key (vitri) references vitri(mavitri),
 constraint fk_MQT foreign key (maquoctich) references quoctich(maquoctich)
 )
 
 ------ trận đấu
 create table trandau
 (
 matrandau char(10) primary key not null,
 luotdau nvarchar(50),
 vongdau nvarchar(50),
 madoinha char(10),
 madoikhach char(10),
 sobanthangdoinha int,
 sobanthuadoinha int,
 sothevangdoinha int,
 sothedodoinha int,
 sothevangdoikhach int,
 sothedodoikhach int,
 ghichu nvarchar(50)
 constraint fk_MDN foreign key (madoinha) references doibong(madoi),
 constraint fk_MDK foreign key (madoikhach) references doibong(madoi),
 )
 drop table trandau;
 
 ------- trận đấu_bàn thắng
 create table trandau_banthang
 (
 matrandau char(10),
 macauthu char(10),
 thoigianphut int,
 ghichu nvarchar(50),
 constraint bt_pk primary key (matrandau,thoigianphut),
 constraint fk_MCT foreign key (macauthu) references cauthu(macauthu)
 )
 drop table trandau_banthang;
 
 -------- trận đấu_cầu thủ
 create table trandau_cauthu
 (
 matrandau char(10),
 madoi char(10),
 macauthu char(10),
 vitri char(10),
 constraint ct_pk primary key (matrandau,macauthu),
 constraint fk_MDB foreign key (madoi) references doibong(madoi),
 constraint fk_MVT foreign key (vitri) references vitri(mavitri)
 )
 drop table trandau_cauthu;
 
 ------ trận đấu_thẻ
 create table trandau_the
 (
 matrandau char(10),
 macauthu char(10),
 thoigianphut int,
 loaithe nvarchar(50),
 ghichu nvarchar(50),
 constraint t_pk primary key (matrandau,thoigianphut),
 constraint fk_CT foreign key (macauthu) references cauthu(macauthu)
 )
 drop table trandau_the;
 ------------- Sân bóng
 insert into sanbong(masan,tensan,diachi,soghe)
 values('SB01','Sân vận động quốc gia Mỹ Đình','Hà Nội',40000);
 insert into sanbong(masan,tensan,diachi,soghe)
 values('SB02','Hàng Đẫy','Hà Nội',22000);
 insert into sanbong(masan,tensan,diachi,soghe)
 values('SB03','Thống Nhất','Thành phố Hồ Chí Minh',19000);
 insert into sanbong(masan,tensan,diachi,soghe)
 values('SB04','Thiên Trường','Nam Định',30000);
 insert into sanbong(masan,tensan,diachi,soghe)
 values('SB05','Lạch Tray','Hải Phòng',30000);
 
 ----------- Tỉnh
 insert into tinh(matinh,tentinh)
 values('T01','Hà Nội');
 insert into tinh(matinh,tentinh)
 values('T02','Hải Phòng');
 insert into tinh(matinh,tentinh)
 values('T03','Nam Định');
 insert into tinh(matinh,tentinh)
 values('T04','Gia Lai');
 insert into tinh(matinh,tentinh)
 values('T05','Đà Nẵng');
 insert into tinh(matinh,tentinh)
 values('T06','Nghệ An');
 
 
 ------------ Quốc tịch
 insert into quoctich(maquoctich,tenquoctich)
 values('QT01','Việt Nam');
 insert into quoctich(maquoctich,tenquoctich)
 values('QT02','Thái Lan');
 insert into quoctich(maquoctich,tenquoctich)
 values('QT03','Úc');
 insert into quoctich(maquoctich,tenquoctich)
 values('QT04','Brasil');
 insert into quoctich(maquoctich,tenquoctich)
 values('QT05','Anh');
 
 ------------ vị trí
 insert into vitri(mavitri,tenvitri)
 values('VT01','Tiền đạo');
 insert into vitri(mavitri,tenvitri)
 values('VT03','Trung vệ');
 insert into vitri(mavitri,tenvitri)
 values('VT04','Thủ môn');
 insert into vitri(mavitri,tenvitri)
 values('VT05','Hậu vệ cánh trái');
 insert into vitri(mavitri,tenvitri)
 values('VT06','Tiền vệ trung tâm');
 insert into vitri(mavitri,tenvitri)
 values('VT07','Hậu vệ cánh phải');
 insert into vitri(mavitri,tenvitri)
 values('VT08','Tiền vệ tấn công');
 insert into vitri(mavitri,tenvitri)
 values('VT09','Tiền vệ chạy cánh');
 
 --------- đội bóng
 insert into doibong(madoi,tendoi,masan,HLV,matinh,diem,sobanthang,sobanthua,soluongcauthu)
 values('DB01','Hoàng Anh Gia Lai','SB03','Lee Tae Hoon','T04',null,null,null,null);
 insert into doibong(madoi,tendoi,masan,HLV,matinh,diem,sobanthang,sobanthua,soluongcauthu)
 values('DB02','Hà Nội FC','SB01','Chu Đình Nghiêm','T01',null,null,null,null);
 insert into doibong(madoi,tendoi,masan,HLV,matinh,diem,sobanthang,sobanthua,soluongcauthu)
 values('DB03','Nam Định','SB05','Nghuyễn Văn Dũng','T03',null,null,null,null);
 insert into doibong(madoi,tendoi,masan,HLV,matinh,diem,sobanthang,sobanthua,soluongcauthu)
 values('DB04','Hải Phòng FC','SB05','Phạm Anh Tuấn','T02',null,null,null,null);
 insert into doibong(madoi,tendoi,masan,HLV,matinh,diem,sobanthang,sobanthua,soluongcauthu)
 values('DB05','SHB Đà Nẵng','SB03','Lê Huỳnh Đức','T05',null,null,null,null);
 insert into doibong(madoi,tendoi,masan,HLV,matinh,diem,sobanthang,sobanthua,soluongcauthu)
 values('DB06','Sông Lam Nghệ An','SB01','Ngô Quang Trường','T06',null,null,null,null);
 
 -------- cầu thủ
 insert into cauthu(macauthu,madoi,tencauthu,vitri,ngaysinh,soao,sobanthang,sothevang,sothedo,maquoctich,solanrasan)
 values('CT01','DB01','Lương Xuân Trường','VT06','04/28/1995',6,null,null,null,'QT01',null);
 insert into cauthu(macauthu,madoi,tencauthu,vitri,ngaysinh,soao,sobanthang,sothevang,sothedo,maquoctich,solanrasan)
 values('CT02','DB01','Nguyễn Văn Toàn','VT01','04/12/1996',9,null,null,null,'QT01',null);
 insert into cauthu(macauthu,madoi,tencauthu,vitri,ngaysinh,soao,sobanthang,sothevang,sothedo,maquoctich,solanrasan)
 values('CT03','DB02','Nguyễn Quang Hải','VT08','04/12/1997',19,null,null,null,'QT01',null);
 insert into cauthu(macauthu,madoi,tencauthu,vitri,ngaysinh,soao,sobanthang,sothevang,sothedo,maquoctich,solanrasan)
 values('CT04','DB02','Đỗ Duy Mạnh','VT07','09/29/1996',28,null,null,null,'QT01',null);
 insert into cauthu(macauthu,madoi,tencauthu,vitri,ngaysinh,soao,sobanthang,sothevang,sothedo,maquoctich,solanrasan)
 values('CT05','DB03','Rafaelson Bezerra Fernandes','VT01','03/30/1997',9,null,null,null,'QT04',null);
 insert into cauthu(macauthu,madoi,tencauthu,vitri,ngaysinh,soao,sobanthang,sothevang,sothedo,maquoctich,solanrasan)
 values('CT06','DB03','Lê Sỹ Minh','VT06','03/23/1993',8,null,null,null,'QT01',null);
 insert into cauthu(macauthu,madoi,tencauthu,vitri,ngaysinh,soao,sobanthang,sothevang,sothedo,maquoctich,solanrasan)
 values('CT07','DB04','Nguyễn Văn Toản','VT04','11/26/1999',30,null,null,null,'QT01',null);
 insert into cauthu(macauthu,madoi,tencauthu,vitri,ngaysinh,soao,sobanthang,sothevang,sothedo,maquoctich,solanrasan)
 values('CT08','DB04','Martin Lò','VT09','09/03/1997',26,null,null,null,'QT03',null);
 insert into cauthu(macauthu,madoi,tencauthu,vitri,ngaysinh,soao,sobanthang,sothevang,sothedo,maquoctich,solanrasan)
 values('CT09','DB05','Hà Đức Chinh','VT01','09/22/1997',9,null,null,null,'QT01',null);
 insert into cauthu(macauthu,madoi,tencauthu,vitri,ngaysinh,soao,sobanthang,sothevang,sothedo,maquoctich,solanrasan)
 values('CT010','DB05','Bùi Tiến Dụng','VT09','11/23/1998',16,null,null,null,'QT01',null);
 insert into cauthu(macauthu,madoi,tencauthu,vitri,ngaysinh,soao,sobanthang,sothevang,sothedo,maquoctich,solanrasan)
 values('CT011','DB06','Phan Văn Đức','VT09','04/11/1996',20,null,null,null,'QT01',null);
 insert into cauthu(macauthu,madoi,tencauthu,vitri,ngaysinh,soao,sobanthang,sothevang,sothedo,maquoctich,solanrasan)
 values('CT012','DB06','Phạm Xuân Mạnh','VT07','02/09/1996',7,null,null,null,'QT01',null);
 truncate table cauthu;
 
 -------- trận đấu
 insert into trandau(matrandau,luotdau,vongdau,madoinha,madoikhach,sobanthangdoinha,sobanthuadoinha,sothevangdoinha,sothedodoinha,sothevangdoikhach,sothedodoikhach,ghichu)
 values('TD01','Lượt đi','Tứ kết','DB01','DB02',null,null,null,null,null,null,null);
insert into trandau(matrandau,luotdau,vongdau,madoinha,madoikhach,sobanthangdoinha,sobanthuadoinha,sothevangdoinha,sothedodoinha,sothevangdoikhach,sothedodoikhach,ghichu)
 values('TD02','Lượt về','Tứ kết','DB03','DB04',null,null,null,null,null,null,null);
 insert into trandau(matrandau,luotdau,vongdau,madoinha,madoikhach,sobanthangdoinha,sobanthuadoinha,sothevangdoinha,sothedodoinha,sothevangdoikhach,sothedodoikhach,ghichu)
 values('TD03','Lượt đi','Bán kết','DB06','DB02',null,null,null,null,null,null,null);
 insert into trandau(matrandau,luotdau,vongdau,madoinha,madoikhach,sobanthangdoinha,sobanthuadoinha,sothevangdoinha,sothedodoinha,sothevangdoikhach,sothedodoikhach,ghichu)
 values('TD04','Lượt đi','Chung kết','DB02','DB04',null,null,null,null,null,null,null);
 insert into trandau(matrandau,luotdau,vongdau,madoinha,madoikhach,sobanthangdoinha,sobanthuadoinha,sothevangdoinha,sothedodoinha,sothevangdoikhach,sothedodoikhach,ghichu)
 values('TD05','Lượt về','Tứ kết','DB06','DB05',null,null,null,null,null,null,null);
 
 ------- trận đấu_bàn thắng
 insert into trandau_banthang(matrandau,macauthu,thoigianphut,ghichu)
 values('TD01','CT03',23,null);
 insert into trandau_banthang(matrandau,macauthu,thoigianphut,ghichu)
 values('TD01','CT02',51,null);
 insert into trandau_banthang(matrandau,macauthu,thoigianphut,ghichu)
 values('TD02','CT05',72,null);
 insert into trandau_banthang(matrandau,macauthu,thoigianphut,ghichu)
 values('TD03','CT011',34,null);
 insert into trandau_banthang(matrandau,macauthu,thoigianphut,ghichu)
 values('TD03','CT03',47,null);
 insert into trandau_banthang(matrandau,macauthu,thoigianphut,ghichu)
 values('TD04','CT03',67,null);
 insert into trandau_banthang(matrandau,macauthu,thoigianphut,ghichu)
 values('TD05','CT09',56,null);
 
 ----- trận đấu_cầu thủ
 insert into trandau_cauthu(matrandau,madoi,macauthu,vitri)
 values('TD01','DB02','CT03','VT08');
 insert into trandau_cauthu(matrandau,madoi,macauthu,vitri)
 values('TD01','DB01','CT02','VT01');
 insert into trandau_cauthu(matrandau,madoi,macauthu,vitri)
 values('TD02','DB03','CT05','VT01');
 insert into trandau_cauthu(matrandau,madoi,macauthu,vitri)
 values('TD03','DB06','CT011','VT09');
 insert into trandau_cauthu(matrandau,madoi,macauthu,vitri)
 values('TD03','DB02','CT03','VT08');
 insert into trandau_cauthu(matrandau,madoi,macauthu,vitri)
 values('TD04','DB02','CT03','VT08');
 insert into trandau_cauthu(matrandau,madoi,macauthu,vitri)
 values('TD05','DB05','CT09','VT01');
 
 ------ trận đấu_thẻ
 insert into trandau_the(matrandau,macauthu,thoigianphut,loaithe,ghichu)
 values('TD01','CT04',23,'vàng',null);
 insert into trandau_the(matrandau,macauthu,thoigianphut,loaithe,ghichu)
 values('TD01','CT02',49,'vàng',null);
 insert into trandau_the(matrandau,macauthu,thoigianphut,loaithe,ghichu)
 values('TD03','CT012',34,'vàng',null);
 insert into trandau_the(matrandau,macauthu,thoigianphut,loaithe,ghichu)
 values('TD03','CT03',86,'vàng',null);
 insert into trandau_the(matrandau,macauthu,thoigianphut,loaithe,ghichu)
 values('TD04','CT04',28,'vàng',null);
 insert into trandau_the(matrandau,macauthu,thoigianphut,loaithe,ghichu)
 values('TD04','CT07',65,'vàng',null);
 insert into trandau_the(matrandau,macauthu,thoigianphut,loaithe,ghichu)
 values('TD05','CT09',32,'vàng',null);
 
    --câu 1: cập nhật dữ liệu từ bảng khác 
	--Cập nhật bảng đội bóng
create trigger trg_CNdoibong on doibong after update as
begin
	update doibong set doibong.diem = capnhatĐB.diem , doibong.sobanthang = capnhatĐB.sobanthang, doibong.sobanthua = capnhatĐB.sobanthua,doibong.soluongcauthu = capnhatĐB.soluongcauthu
	from doibong inner join capnhatĐB on doibong.madoi = capnhatĐB.madoi;
end

select * from doibong;
select * from capnhatĐB;




create trigger trg_CNdoibong1 on capnhatĐB after update as
begin
	update doibong set doibong.diem = capnhatĐB.diem , 
	doibong.sobanthang = capnhatĐB.sobanthang,
	 doibong.sobanthua = capnhatĐB.sobanthua,
	 doibong.soluongcauthu = capnhatĐB.soluongcauthu
	from doibong inner join capnhatĐB on doibong.madoi = capnhatĐB.madoi;
end
      

  
	  
	  
	  -- Cập nhật bảng trận đấu 

  create trigger trg_CNtrandau3 on capnhatTĐ after update as
begin
	update trandau set trandau.sobanthangdoinha = capnhatTĐ.sobanthangdoinha,trandau.sobanthuadoinha = capnhatTĐ.sobanthuadoinha ,trandau.sothevangdoinha = capnhatTĐ.sothevangdoinha,
	trandau.sothedodoinha = capnhatTĐ.sothedodoinha, trandau.sothevangdoikhach = capnhatTĐ.sothevangdoikhach, trandau.sothedodoikhach = capnhatTĐ.sothedodoikhach
	from trandau inner join capnhatTĐ on trandau.matrandau = capnhatTĐ.matrandau;
end

create trigger trg_CNtrandau1 on trandau after update as
begin
	update trandau set trandau.sobanthangdoinha = capnhatTĐ.sobanthangdoinha,trandau.sobanthuadoinha = capnhatTĐ.sobanthuadoinha ,trandau.sothevangdoinha = capnhatTĐ.sothevangdoinha,
	trandau.sothedodoinha = capnhatTĐ.sothedodoinha, trandau.sothevangdoikhach = capnhatTĐ.sothevangdoikhach, trandau.sothedodoikhach = capnhatTĐ.sothedodoikhach
	from trandau inner join capnhatTĐ on trandau.matrandau = capnhatTĐ.matrandau;
end
drop trigger trg_CNtrandau1;

select * from trandau;
select * from capnhatTĐ;

   --Cập nhật bảng cầu thủ
   create trigger trg_CNcauthu on cauthu after update as
begin
	update cauthu set cauthu.sobanthang = capnhatCT.sobanthang,cauthu.sothevang = capnhatCT.sothevang,
	cauthu.sothedo = capnhatCT.sothedo, cauthu.solanrasan = capnhatCT.solanrasan
	from cauthu inner join capnhatCT on cauthu.macauthu = capnhatCT.macauthu;
end


   create trigger trg_CNcauthu1 on capnhatCT after update as
begin
	update cauthu set cauthu.sobanthang = capnhatCT.sobanthang,
	cauthu.sothevang = capnhatCT.sothevang,
	cauthu.sothedo = capnhatCT.sothedo, cauthu.solanrasan = capnhatCT.solanrasan
	from cauthu inner join capnhatCT on cauthu.macauthu = capnhatCT.macauthu;
end




select * from cauthu;
select * from capnhatCT;
drop trigger trg_CNcauthu;
