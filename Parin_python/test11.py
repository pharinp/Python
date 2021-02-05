#แบบฝึกหัด 4.1
listmenu = [0,0,0,0,0]
i = 1
choice = 0
j = 0
x = 0
def menu() :
    global choice
    print('โปรแกรมร้านค้า\n1.แสดงรายการสินค้า\n2.หยิบสินค้าเข้าตะกร้า\n3.แสดงรายการจำนวนและราคาของสินค้าที่หยิบ\n5.ปิดรายการ')
    choice =input('เลือกเมนู :')
    screen_clear()
def menu1() :
   print('รายการสินค้า\n*********************************\n1.มาม่า 10 บาท\n2.กาแฟ 20 บาท\n3.กระดาษทิชชู่ 20 บาท\n4.ปลากระป๋อง 15 บาท\n5.ผงซักผ้า 30 บาท')
def menu2() :
    global name
    print('1.มาม่า 10 บาท\n2.กาแฟ 20 บาท\n3.กระดาษทิชชู่ 20 บาท\n4.ปลากระป๋อง 15 บาท\n5.ผงซักผ้า 30 บาท\n6.ออกจากฟังก์ชัน')
    name = int(input('หยิบสินค้าหมายเลข '))
    if name == 1 :
        listmenu[0] += 1
    elif name == 2 :
        listmenu[1] +=1
    elif name == 3 :
        listmenu[2] +=1
    elif name == 4 :
        listmenu[3] +=1
    elif name == 5 :
        listmenu[4] +=1
    screen_clear()
def menu3() :
    list_score = ['มาม่า','กาแฟ','กระดาษทิชชู่','ปลากระป๋อง','ผงซักผ้า']
    list_price = [10,20,20,15,30]
    print("{0:-<13}{1:-<13}{2:-<13}{3}".format('สินค้า','ราคา','จำนวน','ราคารวม'))
    for i in range(0,5) :
        print("{0:-<13}{1:-<13}{2:-<13}{3}".format(list_score[i],list_score[i],list_score[i],list_score[i]*list_score[i]))
def menu4() :
    print('\t\nรายการสินค้า\n1.มาม่า\n2.กาแฟ\n3.กระดาษทิชชู่\n4.ปลากระป๋อง\n5.ผงซักผ้า')
    depick = int(input('เลือกสินค้าที่จะหยิบออก หรือพิมพ์ -1 เพื่อออก'))
    if depick == 1 :
        listmenu[0] -= 1
    elif depick == 2 :
        listmenu[1] -= 1
    elif depick == 3 :
        listmenu[2] -= 1
    elif depick == 4 :
        listmenu[3] -= 1
    elif depick == 5 :
        listmenu[4] -= 1

def screen_clear() :
    clearscreen = os.system('cls')

while True :
    menu()
    if choice == '1' :
        screen_clear()
        menu1()
    elif choice == '2' :
        screen_clear()
        menu2()
    elif choice == '3' :
        screen_clear()
        menu3()
    elif choice == '4' :
        menu4()
        screen_clear()
    elif choice == '5' :
        c = input('ต้องการใช้งานโปรแกรมต่อหรือไม่ y/n :')
        if c.lower() == 'y' :
            screen_clear()
        elif c.lower() == 'n' :
            screen_clear()
            break
    