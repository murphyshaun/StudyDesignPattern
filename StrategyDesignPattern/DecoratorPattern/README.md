## MilkTrea price

## Base price: 5$

## Additional price:
	- Bubble: 1$
	- BlackSugar: 2$
	- EggPudding: 3$
	- FruitPudding: 3$
	- WhiteBubble: 1.5$

## Test case
	- EggPuddingAndFruitPuddingBlackBubbleMilkTea: 5 + 1 + 2 + 3 + 3 = 14$
	- EggPuddingBlackSugarWhiteBubbleMilkTea: 5 + 1.5 + 2 + 3 = 11.5$

## Tóm tắt
- Kế thừa là một hình thức mở rộng, nhưng không nhất thiết là cách tốt nhất để đạt được sự linh hoạt trong các thiết kế của chúng tôi.
- Trong các thiết kế của chúng tôi, chúng tôi nên cho phép hành vi được mở rộng mà không cần phải sửa đổi code hiện có.
- Composition và delegation thường có thể được sử dụng để thêm các hành vi mới in runtime.
- Decorator Pattern cung cấp một sự thay thế cho subclass để mở rộng hành vi.
- Decorator Pattern bao gồm một tập hợp các lớp trang trí được sử dụng để bọc các concrete component (concrete component kế thừa từ lớp component).
- Các lớp Decorator phản chiếu các loại thành phần mà nó trang trí. (Trên thực tế, chúng cùng loại với các component mà chúng trang trí, thông qua kế thừa hoặc implement interface.)
- Các Decorator thay đổi hành vi của các component của chúng bằng cách thêm chức năng mới trước và/hoặc sau (hoặc thậm chí thay thế) các cuộc gọi phương thức đến component.
- Bạn có thể bọc một component với bao nhiêu decorator tuỳ thích.
- Decorator thường transparent (trong suốt – nghĩa là client chỉ biết đến các lớp base class trừu tượng bên trên mà không cần biết đến các lớp con cụ thể) với client của component.
- Decorators có thể dẫn đến nhiều đối tượng nhỏ trong thiết kế của bạn và việc sử dụng quá mức có thể phức tạp.