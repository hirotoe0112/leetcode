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
javac Hello.java
java Hello

javac -classpath ../lib Hello.java
java -classpath ../lib Hello
```

## dockerを抜ける
```
exit
```

## docker終了
```
docker-compose down
```