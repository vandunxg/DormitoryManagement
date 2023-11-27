# QUY TẮC ĐẶT TÊN BIẾN

Quy tắc đặt tên biến dành cho các control của textbox nhằm giúp mã nguồn rõ ràng và dễ hiểu sẽ giúp cho mã nguồn dễ đọc, dễ hiểu và dễ bảo trì.

## Các cách đặt tên biến
* Tên biến mô tả mục đích: customerName, orderDate, productQuantity.

* Tên biến mô tả nội dung: price, discount, tax.

## Đặt tên biến cho control của textbox

#### Tiền tố mô tả mục đích của TextBox:

* txt - biến đại diện cho trường nhập dữ liệu

* lbl - biến đại diện cho nhãn

* cmb - biến đại diện cho hộp danh sách

* rad - biến đại diện cho hộp kiểm

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
txtCustomerName - biến đại diện cho trường nhập tên khách hàng

lblOrderDate - biến đại diện cho nhãn ngày đặt hàng

cmbProductTypes - biến đại diện cho hộp danh sách loại sản phẩm

radMale - biến đại diện cho hộp kiểm giới tính nam
```

Tiền tố mô tả nội dung:
```
txtEmail - biến chứa địa chỉ email

phone - biến chứa số điện thoại

price - biến chứa giá sản phẩm
```

Tiền tố mô tả thuộc tính:
```
readonlytxtCustomerName - biến đại diện cho trường nhập tên khách hàng chỉ đọc

requiredtxtEmail - biến đại diện cho trường nhập địa chỉ email bắt buộc

autocompletetxtPhone - biến đại diện cho trường nhập số điện thoại tự động hoàn thành
```

@updating...
