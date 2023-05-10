/**
* giảm giá khi người dùng đặt trước một sản phẩm của VINFAST
*/
function preOrderPrice(orinialPrice) {
  return orinialPrice*0.8;
}

/**
* tiếp tục thêm tính năng khuyến mãi thông thường, ví dụ nếu giá gốc < 200 thì giảm 10%, còn > thì giảm tối đa 30
*/
function promotionPrice(orinialPrice) {
  return orinialPrice <= 200 ? orinialPrice * 0.9 : orinialPrice - 30;
}

/**
* giá mặc định
*/
function defaultPrice(originalPrice) {
  return orinialPrice;
}
