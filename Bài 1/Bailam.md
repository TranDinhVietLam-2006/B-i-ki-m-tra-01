Câu 1: Trình bày sự khác nhau giữa Value Types và Reference Types trong C# về cơ chế lưu trữ vùng nhớ (Stack vs Heap).

Value Types là kiểu dữ liệu lưu trực tiếp giá trị của biến. Các kiểu như int, double, bool, char và struct thuộc nhóm này. Đối với biến cục bộ, giá trị thường được lưu trên Stack.

Reference Types là kiểu dữ liệu mà biến lưu tham chiếu đến đối tượng thay vì lưu trực tiếp dữ liệu. Các kiểu như class, object, string và array thuộc nhóm này. Đối tượng thường được lưu trên Heap, còn biến tham chiếu dùng để trỏ đến đối tượng đó.

Câu 2: Tính năng Init-only Properties (init) trong C# 9/10 khác gì so với thuộc tính có set thông thường? Nêu trường hợp sử dụng thực tế.

Init-only Property sử dụng từ khóa init để cho phép thuộc tính được gán giá trị trong quá trình khởi tạo đối tượng. Sau khi đối tượng được khởi tạo thì giá trị của thuộc tính đó không thể thay đổi.

Trong khi đó, thuộc tính sử dụng set có thể được gán giá trị lúc khởi tạo và cũng có thể thay đổi sau khi đối tượng đã được tạo.

Init thường được sử dụng với những thông tin chỉ cần thiết lập một lần và không muốn bị thay đổi trong quá trình chương trình chạy, giúp hạn chế việc thay đổi dữ liệu ngoài ý muốn.

Câu 3: Phân biệt sự khác nhau giữa phương thức virtual ở lớp cha và phương thức override ở lớp con khi triển khai tính Đa hình (Polymorphism).

Virtual là từ khóa được sử dụng trong lớp cha để khai báo một phương thức mà lớp con có thể ghi đè lại.

Override được sử dụng trong lớp con để định nghĩa lại cách hoạt động của phương thức virtual đã được khai báo trong lớp cha.

Sự kết hợp giữa virtual và override cho phép chương trình thực hiện tính đa hình, tức là cùng một phương thức nhưng khi được gọi có thể thực hiện cách xử lý khác nhau tùy thuộc vào đối tượng thực tế.

Câu 4: Tại sao một thành phần được khai báo là static trong Class lại không thể truy xuất thông qua một Object Instance được tạo bằng toán tử new?

Thành phần static thuộc về Class chứ không thuộc về từng Object Instance. Vì vậy, khi tạo các đối tượng bằng từ khóa new thì các đối tượng đó không có một bản riêng của thành phần static mà cùng sử dụng thành phần chung của Class.

Do đó, thành phần static phải được truy xuất thông qua tên của Class thay vì thông qua một Object Instance.
