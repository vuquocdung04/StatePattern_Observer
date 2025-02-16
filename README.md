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
## 🚀ObserverPattern:
- Cấu trúc (Minh họa):
	- ObserverManager: quản lí add, remove listener, các thông báo:..
		- ví dụ: thông báo thay đổi score, update hpBar,.... => Gọi chung là notify
		- trong này mỗi notify quản lí 1 thông tin: update score, update hpBar,..
	- PlayerController: sẽ bấm space để truyền thông tin tới Notify, những thằng nào đăng kí lắng nghe sẽ nhận được thông tin và thay đổi
	- UIManager: ở đây nó đăng kí lắng nghe Notify: update score mỗi khi player bấm space
		- Khi player bấm space thì hàm trong UIManger sẽ được gọi
- 🤔Vậy tại sao ?
	- trong UIManager không public 1 method nào đó xong ở PlayerController mỗi khi bấm space thì gọi tới UIManager.instance.method..
	- 👉 gọi trực tiếp có thể dùng với ít đối tượng, vd: có 100 đối tượng mà method nó dài thì phải copy paste liên tục
	- 👉 trong khi đó nếu dùng observer thì sẽ ngắn gọn hơn, dễ quản lí, sau mà core game thay đổi thì mình chỉ cần vào ObserverManager để check xem thằng nào đang lắng nghe
