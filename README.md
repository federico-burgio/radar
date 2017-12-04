# Radar App
This app was created for the Microservices class @ UniMe.

## Build docker image
### Login into docker registry (you need an account @ hub.docker.com)
docker login

### Build the image
docker build . --rm -f Dockerfile -t radar:latest

### Tag it and send it to the registry
docker tag radar radar:latest & docker push radar:latest

### Run on your local docker
docker run -d -p 5000:5000 radar:latest

## Run it with Minikube
### Create deployment
kubectl run radar radar:latest --port=5000

### Create a service for the deployment
kubectl expose deployment radar --type=NodePort

### Get the url of the service
minikube service radar --url

## Useful Links
### Docker
https://www.docker.com

### Docker Hub - Official Registry
https://hub.docker.com

### Visual Studio Code
https://code.visualstudio.com

## Credits
Federico Burgio - Lead Architect @ BaxEnergy
http://www.baxenergy.com
http://www.freemindfoundry.com
