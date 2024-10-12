# Sử Dụng NavMesh Obstacle Trong Unity

## Hỏi AI: Cách Sử Dụng NavMesh Obstacle

### NavMesh Obstacle là gì?

**NavMesh Obstacle** là một thành phần trong Unity được sử dụng để tạo ra các vật cản trong môi trường, ngăn cản các nhân vật hoặc đối tượng điều hướng (navigation) qua những khu vực nhất định. Đối tượng được gắn **NavMesh Obstacle** sẽ trở thành vật cản và có thể tĩnh hoặc động, tùy thuộc vào cách bạn cấu hình nó.

NavMesh Obstacle trong Unity được sử dụng để đại diện cho các vật cản không di chuyển trong môi trường, giúp AI tránh né chúng khi di chuyển dựa trên hệ thống NavMesh. Đây là một cách để làm cho AI không va vào các chướng ngại vật cố định.

Các bước để sử dụng NavMesh Obstacle:
1. Thêm NavMesh Obstacle Component:
    Chọn đối tượng bạn muốn làm chướng ngại vật (ví dụ: một bức tường).
    Thêm thành phần NavMesh Obstacle vào đối tượng thông qua Inspector.

2. Thiết lập NavMesh Obstacle:
    Carve: Nếu hộp kiểm này được bật, đối tượng sẽ cắt vào lưới NavMesh, khiến nó trở thành một vùng không thể truy cập.
    Shape: Chọn giữa hình hộp (Box) hoặc hình trụ (Capsule) để phù hợp với hình dạng của đối tượng.
    Center và Size: Điều chỉnh để khớp với kích thước và vị trí của đối tượng trên NavMesh.

3. Tối ưu hóa:
    Nếu các vật cản không thay đổi vị trí nhiều trong thời gian thực, việc bật tính năng Carve có thể là một lựa chọn tối ưu hóa tốt vì nó cho phép NavMesh tự động cập nhật xung quanh vật cản này.
