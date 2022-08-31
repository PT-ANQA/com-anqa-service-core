docker build -f Dockerfile.test.build -t com-Anqa-service-core-webapi:test-build .
docker create --name com-Anqa-service-core-webapi-test-build com-Anqa-service-core-webapi:test-build
mkdir bin
docker cp com-Anqa-service-core-webapi-test-build:/out/. ./bin/publish
docker build -f Dockerfile.test -t com-Anqa-service-core-webapi:test .
