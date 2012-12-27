#include "SDK\SDK.h"

//Prototypes
void RegisterEvents();

void event_serverPulse(SquirrelArgumentsInterface* pArguments, SquirrelArgumentInterface* pReturn, void* pChunk);
void event_consoleInput(SquirrelArgumentsInterface* pArguments, SquirrelArgumentInterface* pReturn, void* pChunk);
void event_consoleOutput(SquirrelArgumentsInterface* pArguments, SquirrelArgumentInterface* pReturn, void* pChunk);
void event_playerSpawn(SquirrelArgumentsInterface* pArguments, SquirrelArgumentInterface* pReturn, void* pChunk);