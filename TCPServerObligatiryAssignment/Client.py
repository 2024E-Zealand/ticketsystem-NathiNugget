from socket import * 


serverName = "localhost"
serverPort = 727

clientSocket = socket(AF_INET, SOCK_STREAM) # Stream: TCP, DRAM: UDP
clientSocket.connect( (serverName, serverPort))

def SendPrompt(byteCmd, byteNumbers):
     
    clientSocket.send(byteCmd)

    returnSentence = clientSocket.recv(1024)
    print(returnSentence)
    
    clientSocket.send(byteNumbers)
    returnSentence = clientSocket.recv(1024)
    print(returnSentence)
    print("Write new command: ")
while True: 

#læser input fra skærm/tastatur
    sentence = input("Input command: ")
    sentence += '\r\n'
    byteCmd = sentence.encode() # input laves om til bytes, således at der kan sendes
    numbers = input("Write two numbers with a space: ")
    numbers = '\r\n'
    byteNumbers = numbers.encode()
    SendPrompt(byteCmd, byteNumbers)

clientSocket.close() 