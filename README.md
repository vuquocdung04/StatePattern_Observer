# StatePattern_Observer
## 🚀StatePattern:
- Cấu trúc (Minh họa):
	- SateBase:  abstract định nghĩ method abstract cho lớp con kế thừa
		- ví dụ: _Start,_Update,....
	- StateColor: kế thừa từ StateBase, định nghĩa lại hành vi _Start, _Update,..
		- A: đổi màu xanh
		- S: đổi màu đỏ
		- D: đổi màu vàng
	- StateScale: kế thừa từ StateBase, định nghĩa lại hành vi _Start, _Update,..
		- A: tăng scale lên 2
		- S: tăng scale lên 10
		- D: giảm scale xuống 0.5
	- PlayerController: 
		- Gọi tới StateBase currentState;
		- ở hàm Start cho currentState = StateColor
		- Update thì check nếu bấm phím 1 thì sẽ destroy currentState hiện tại và thay bằng StateScale và ngược lại