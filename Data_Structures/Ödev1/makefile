basla: program
	./bin/program.exe
program: Node.o DoubleLinkedList.o File.o main.o
	g++ ./lib/Node.o ./lib/DoubleLinkedList.o ./lib/File.o ./lib/main.o -o ./bin/program
	
Node.o:
	g++ -I "./include" -c ./src/Node.cpp -o ./lib/Node.o 
DoubleLinkedList.o:
	g++ -I "./include" -c ./src/DoubleLinkedList.cpp -o ./lib/DoubleLinkedList.o 
File.o:
	g++ -I "./include" -c ./src/File.cpp -o ./lib/File.o 
main.o:
	g++ -I "./include" -c ./src/main.cpp -o ./lib/main.o 
