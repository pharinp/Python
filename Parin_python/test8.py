print('ป้อนชื่ออาหารสุดโปรดของคุณ หรือ exit เพื่อออกจากโปรแกรม')
thislist = [ ]
i = 1
x=0
j=0
while(i <= 100) :
    name = str(input('อาหารโปรดอันดับ ที่ '+str(i)+' '))
    i+=1
    if name == 'exit' :
            break
    thislist.append(name)
print('อาหารสุดโปรดของคุณมีดังนี้',end='\t')
for x in thislist :
    j+=1
    print(j,x,end='\t')