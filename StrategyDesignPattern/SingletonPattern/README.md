## Tóm tắt
- Mẫu Singleton đảm bảo bạn có nhiều nhất một instance trong ứng dụng của mình.
- Mẫu Singleton cũng cung cấp một điểm truy cập toàn cục cho instance đó.
- Việc triển khai Java của mẫu Singleton sử dụng một private constructor, một static method kết hợp với một biến static.
- Kiểm tra các hạn chế về hiệu suất và tài nguyên của bạn và cẩn thận chọn một triển khai Singleton thích hợp cho các ứng dụng đa luồng (và chúng ta nên xem xét tất cả các ứng dụng đa luồng!).
- Cảnh giác với việc thực hiện double-checked locking; nó không an toàn trong các phiên bản trước Java 2, version 5.
- Hãy cẩn thận nếu bạn đang sử dụng nhiều class loaders; điều này có thể đánh bại việc thực hiện Singleton và dẫn đến nhiều instances.
- Nếu bạn đang sử dụng JVM trước 1.2, bạn sẽ cần phải tạo một sổ đăng ký Singletons để đánh bại trình thu gom rác (garbage collector).
 
## Các trường hợp sử dụng Singleton tốt nhất:
    + Các tài nguyên toàn cục (global resource)
    + Các cài đặt trong ứng dụng (config)
    + Lưu hành vi ứng dụng (logging)
    + Lưu bộ nhớ đệm (cache)
Các cách tạo Singleton:
Tạo thẳng (static a  = new …): nhược điểm lãng phí bộ nhớ khi trong 1 thời gian dài không dùng (tìm hiểu lazy loading: chỉ khởi tạo khi dùng)
Nếu sử dụng lazy initialization sẽ gặp vấn đề với multi threading
