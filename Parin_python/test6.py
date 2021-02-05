print('เลือกเมนูเพื่อทำรายการ')
print('กด 1 เลือกเหมาจ่าย')
print('กด 2 เลือกจ่ายเพิ่ม')
select = input('โปรดกดรหัส ')
select1 = int(select)
value = input('enter value :')
value1 = int(value)
if select1 == 2 :
    if value1 > 25 :
        print('จ่าย 80 บาท')
    else : 
        print('จ่าย 25 บาท')
elif select1 == 1 :
    if value1 > 25 :
        print('จ่าย 55 บาท')
    else : 
        print('จ่าย 25 บาท')