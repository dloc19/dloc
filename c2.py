import numpy as np
import matplotlib.pyplot as mp

def nhap_mang(n):
    a = []
    for i in range(n):
        k = int(input("a[{}] = ".format(i)))
        a.append(k)
    return np.array(a)

def ghi_file(a_sorted):
    with open("dloc.txt", "w") as file:
        file.write("dong 1:" + a_sorted[:2] + "\n")
        file.write("dong 2:" + a_sorted[2:])
    print("đã ghi vào tệp dloc.txt")

def to2D(a, n):
    try:
        t = int(input("nhap so dong cua ma tran = "))
        if n % t != 0: raise ValueError
        k = a.reshape(t, n//t)
        return k
    except:
        print(ValueError, "không thể reshape")
        return


n = int(input("nhap so luong phan tu cua mang = "))
a = nhap_mang(n)
print(a)

#tim vị trí và giá trị không duyệt mảng
vi_tri = np.array(np.where(a%2!= 0) and np.where(a%3==0))
gia_tri = np.array(a[vi_tri])

#tính tổng các số đã tìm
tong = np.sum(gia_tri)

#sắp xếp giảm kiểu headsorrt
a_sorted_giam = np.sort(a, kind = "headsort")[::-1]
print("mang sau khi sap xep giam: ", a_sorted_giam)

#sắp xếp tăng kiểu mặc định quicksort
a_sorted_tang = np.sort(a)
print("tong = ", tong)

#chèn k vào vị trí cho trước
k = int(input("nhap k = "))
vt = int(input("nhap vị trí cần chèn vt = "))
a_inserted = np.insert(a, vt, k)
print("mang sau khi chèn: ", a_inserted)
#xoa ở vị trí
a_removed = np.remove(a, 2)

#chuyển thành mảng 2 chiều
b = to2D(a, n)
print("mang sau khi chuyen: ", b)

y = np.array([44,67,99,80,120])
mp.title("BIỂU ĐỒ DLOC")
mylabels= {"Cam", "Chanh", " Xoài", "Bưởi", "Mít"}
wp = {"linewidth" : 1, "edgecolor":"black"}
myexplode = [0.1 , 0.1, 0, 0, 0.1]
mp.pie(y, autopct = "%.2f", labels = mylabels, explode = myexplode, wedgeprops = wp ,shadow = True)
mp.show()