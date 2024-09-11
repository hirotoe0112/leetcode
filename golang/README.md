## docker起動
```
docker-compose up -d
```

## dockerに入る
```
docker exec -it CONTAINER_ID //bin/bash
```

## 実行
```
go run test.go
go run add-two-integers_2235.go -num1=1 -num2=2

go build test.go
go run ./test

go fmt test.go
```

## dockerを抜ける
```
exit
```

## docker終了
```
docker-compose down
```