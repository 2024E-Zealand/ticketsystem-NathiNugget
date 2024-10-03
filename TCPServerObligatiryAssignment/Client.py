from socket import * 
import time

#This class is an implmenentation based on a response with the server using a normal TCP-connection. 
#Client writed thier command, Add, Subtract or Random, presses enter then provides two numbers spaced and presses enter, then server responds with the answer of the operation

serverName = "localhost"
serverPort = 727

clientSocket = socket(AF_INET, SOCK_STREAM) # Stream: TCP, DRAM: UDP
clientSocket.connect( (serverName, serverPort))

def SendPrompt(byteCmd, byteNumbers):
     
    clientSocket.send(byteCmd)

    returnSentence = clientSocket.recv(1024)
    print(returnSentence.decode())
    time.sleep(0.5)
    clientSocket.send(byteNumbers)
    returnSentence = clientSocket.recv(1024)
    print(returnSentence.decode())
    print("Write new command: ")


#læser input fra skærm/tastatur
sentence = "Random"
print(sentence)
sentence = sentence + "\r\n"
bytecmd = sentence.encode() # input laves om til bytes, således at der kan sendes
numbers = input("Write two numbers with a space: ")
numbers = numbers + "\r\n"
bytenumbers = numbers.encode()
SendPrompt(byteCmd=bytecmd, byteNumbers=bytenumbers)

#læser input fra skærm/tastatur
sentence = "Add"
print(sentence)
sentence = sentence + "\r\n"
bytecmd = sentence.encode() # input laves om til bytes, således at der kan sendes
numbers = input("Write two numbers with a space: ")
numbers = numbers + "\r\n"
bytenumbers = numbers.encode()
SendPrompt(byteCmd=bytecmd, byteNumbers=bytenumbers)

#læser input fra skærm/tastatur
sentence = "Add"
print(sentence)
sentence = sentence + "\r\n"
bytecmd = sentence.encode() # input laves om til bytes, således at der kan sendes
numbers = input("Write two numbers with a space: ")
numbers = numbers + "\r\n"
bytenumbers = numbers.encode()
SendPrompt(byteCmd=bytecmd, byteNumbers=bytenumbers)

time.sleep(2)

clientSocket.close() 