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