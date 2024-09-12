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
go run no_2235_add-two-integers.go -num1=1 -num2=2
go run no_1480_running_sum_of_1d_array.go 1 2 3 4 5

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