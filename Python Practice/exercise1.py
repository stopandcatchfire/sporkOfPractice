name = input("Give me your name: ")
dob = int(input("Give me your age: "))
tilhundred = (100-dob)+2017
repeat = int(input("Give me another number: "))
i = 0
for i in range(0,repeat):
	print("Greetings " + name + " \nYou will turn 100 in " + str(tilhundred))

