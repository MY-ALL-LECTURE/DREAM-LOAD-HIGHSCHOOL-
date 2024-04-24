# WEB SERVER(SPRINGBOOT)

페이지 표시하기
---
> src>main>java.com.example.demo.controller.ArduinoController
```
@Controller
@Slf4j
@RequestMapping("/arduino")
public class ArduinoController {

    @GetMapping("/index")
    public void index(){
        log.info("GET/arduino/index");
    }
}

```

URL PAGE 확인
---
> Browser -> http://localhost:8080/arduino/index <br>

![20240425002735](https://github.com/MY-ALL-LECTURE/DREAM-LOAD/assets/84259104/579be866-40a1-4cfc-9e97-e956a8697dce)



TEST
---
> TEST
```
TEST
```

TEST
---
> TEST
```
TEST
```

TEST
---
> TEST
```
TEST
```
