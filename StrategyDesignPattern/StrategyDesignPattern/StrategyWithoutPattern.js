function getPrice(originalPrice, typePromotion = 'default') {
  // giảm giá khi người dùng đạt trước một sản phẩm của VINFAST
  if (typePromotion === "preOrder") {
    return originalPrice*0.8; // giảm 20%
  } // ở giai đoạn này nếu như bạn đã biết về SOLID thì nó đã phá vỡ nguyên tắc đầu tiên. đó là nguyên tắc trách nhiệm duy nhất
  
  // tiếp tục thêm tính năng khuyến mãi thông thường, ví dụ nếu giá gốc < 200 thì giảm 10%, còn > thì giảm tối đa 30
  if (typePromotion === "promotion") {
    return origialPrice <= 200 ? originalPrice * 0.9 : origialPrice - 30;
  }
  
  //... if black five day, 11/11,...
  // thêm nhiều toán tử if trong tương lai
  // nếu lỗi 1 if ở trong này thì sẽ bị exception cho toàn bộ
  
  // thời xưa chưa có marketing như bây giờ
  if (typePromotion === "promotion") {
    return originalPrice;
  }
}
