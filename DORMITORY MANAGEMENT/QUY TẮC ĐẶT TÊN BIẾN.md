# QUY TẮC ĐẶT TÊN BIẾN

Quy tắc đặt tên biến dành cho các control của textbox nhằm giúp mã nguồn rõ ràng và dễ hiểu sẽ giúp cho mã nguồn dễ đọc, dễ hiểu và dễ bảo trì.

## Các cách đặt tên biến
* Tên biến mô tả mục đích: customerName, orderDate, productQuantity.

* Tên biến mô tả nội dung: price, discount, tax.

## Tên biến cho control của textbox

#### Tiền tố mô tả mục đích của TextBox:

* txt_ - biến đại diện cho trường nhập dữ liệu

* lbl_ - biến đại diện cho nhãn

* cmb_ - biến đại diện cho hộp danh sách

* rad_ - biến đại diện cho hộp kiểm

#### Tiền tố mô tả nội dung của TextBox:

* name - biến chứa tên

* email - biến chứa địa chỉ email

* phone - biến chứa số điện thoại

* price - biến chứa giá

#### Tiền tố mô tả thuộc tính của TextBox:

* readonly - biến đại diện cho trường nhập dữ liệu chỉ đọc

* required - biến đại diện cho trường nhập dữ liệu bắt buộc

* autocomplete - biến đại diện cho trường nhập dữ liệu tự động hoàn thành

#### Ví dụ:

Tiền tố mô tả mục đích:
```
txt_CustomerName - biến đại diện cho trường nhập tên khách hàng

lbl_OrderDate - biến đại diện cho nhãn ngày đặt hàng

cmb_ProductTypes - biến đại diện cho hộp danh sách loại sản phẩm

rad_Male - biến đại diện cho hộp kiểm giới tính nam
```

Tiền tố mô tả nội dung:
```
txtEmail_ - biến chứa địa chỉ email

phone_ - biến chứa số điện thoại

price_ - biến chứa giá sản phẩm
```

Tiền tố mô tả thuộc tính:
```
readonly_txtCustomerName - biến đại diện cho trường nhập tên khách hàng chỉ đọc

required_txtEmail - biến đại diện cho trường nhập địa chỉ email bắt buộc

autocomplete_txtPhone - biến đại diện cho trường nhập số điện thoại tự động hoàn thành
```

### Quy tắc đặt tên cho các control của textbox
```
Button: btn_Example

Label: lbl_Example

TextBox: txt_Example

ComboBox: cbo_Example

DataGridView: dgv_Example

CheckBox: chk_Example

RadioButton: rad_Example

ListBox: lst_Example

GroupBox: grp_Example

Panel: pnl_Example
```
