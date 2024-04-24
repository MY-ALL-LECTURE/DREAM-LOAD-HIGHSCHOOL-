# WEB SERVER(SPRINGBOOT)

URL MAPPING 
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
> Browser -> http://localhost:8080/arduino/index
![20240425002735](https://github.com/MY-ALL-LECTURE/DREAM-LOAD/assets/84259104/3b0bf316-2ab9-4572-8ee4-9fea0e856c51)
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
