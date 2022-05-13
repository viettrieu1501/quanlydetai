# PHẦN MỀM QUẢN LÝ ĐỀ TÀI

 Ứng dụng quản lý đề tài sử dụng C#, SQL SERVER

![Hình ảnh demo sản phẩm](/images/

## Nội dung

* [Tính năng](#Tính-năng)
* [Cài đặt](#Cài-đặt)
* [Môi trường](#Môi-trường)
* [Tài liệu tham khảo](#Tài-liệu-tham-khảo)
* [Bugs và các vấn đề](#Bugs-và-các-vấn-đề)
* [Ảnh chụp màn hình](#Ảnh-chụp-màn-hình)
* [Tác giả](#Tác-giả)
* [Giấy phép](#Giấy-phép)

## Tính năng

* Đăng ký đề tài
* Quản lý đề tài
* Quản lý nhân viên
* Quản lý bộ môn
* Quản lý khoa
* Quản lý tài khoản
* Báo cáo 

## Cài đặt

**1. Tải các thành phần liên quan**

* Git clone https://github.com/
* Khôi phục file backup database /Database/

**2. Chỉnh sửa connection string**

* Mở file DAO/DataProvider.cs 
* Sửa đổi  private string connectionStr = @"Data Source=**\**;Initial Catalog=QL_DeTai;Integrated Security=True";
với tên server tương ứng

**3. Tài khoản đăng nhập hệ thống**
username: admin
password: admin

## Môi trường

* [Visual Studio 2019](https://visualstudio.microsoft.com/fr/downloads/?rr=https%3A%2F%2Fwww.google.com.vn%2F)
* [SQL Server 2019](https://www.microsoft.com/en-us/sql-server/sql-server-2019)

## Tài liệu tham khảo

Tai liệu hỗ trợ việc sử dụng C# [documentation](https://docs.microsoft.com/en-us/dotnet/csharp/).

## Bugs và các vấn đề

Bạn có câu hỏi hoặc vấn đề với dự án? [Đặt câu hỏi](https://github.com/) tại đây trên Github.

## Ảnh chụp màn hình

* `Đăng nhập`

![Đăng nhập](/images/)

* `Đăng ký đề tài`

![Đăng ký đề tài](/images/)

* `Quản lý nhân viên`

![Quản lý nhân viên](/images/)

* `Quản lý bộ môn`

![Quản lý bộ môn](/images/)

* `Quản lý khoa`

![Quản lý khoa](/images/)

## Tính năng đang phát triển


## Tác giả

* **Phạm Viết Triều** - [viettrieu1501](https://github.com/viettrieu1501)
* **Vũ Anh Đức**
* **Nguyễn Việt Đức**
* **Nguyễn Xuân Đức**

## Giấy phép

[MIT](https://opensource.org/licenses/MIT)
