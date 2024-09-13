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
gcc test.c -o ./bin/test
./bin/test
```

## dockerを抜ける
```
exit
```

## docker終了
```
docker-compose down
```